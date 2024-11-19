using Crews.PlanningCenter.Api.Models;
using Crews.PlanningCenter.Calendar.Models.Entities;
using Xunit.Abstractions;

namespace Crews.PlanningCenter.Calendar.Tests;

public class Sandbox(ITestOutputHelper output)
{
	private readonly ITestOutputHelper _output = output;

	[Fact]
	public async Task SandboxTest()
	{
		PlanningCenterPersonalAccessToken token = new()
		{
			AppID = "d1cbb1701a9798ef9490b9f9ff42805fefc29dbb9a6a07aaac19981196ff47ae",
			Secret = "d02791c7c863526bf78c6c4e17185b2281952a14a7d2f076f57f7aee20f12dca"
		};

		HttpClient client = new();
		client.DefaultRequestHeaders.Authorization = token;

		PlanningCenterCalendarService service = new(client, new("https://api.planningcenteronline.com/"));
		Attachment? attachment = await service.Attachments.WithID("6885").GetAsync();

		_output.WriteLine(attachment?.Name);
	}
}
