using Crews.PlanningCenter.Api.Extensions;
using Crews.PlanningCenter.Calendar.Models.Resources;

namespace Crews.PlanningCenter.Calendar;

public class PlanningCenterCalendarService : ICalendarService
{
	private readonly HttpClient _httpClient;
	private readonly Uri _baseUri;

	public PlanningCenterCalendarService(HttpClient httpClient, Uri? baseUri)
	{
		_httpClient = httpClient;
		_baseUri = baseUri ?? httpClient.BaseAddress ?? throw new InvalidOperationException(
			$"A base URI must be defined in either '{nameof(httpClient)}.BaseAddress' or '{nameof(baseUri)}'.");
	}
  public AttachmentResourceCollection Attachments => new(_baseUri.SafelyAppendPath("calendar/v2/attachments"), _httpClient);
}
