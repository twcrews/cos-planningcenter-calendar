using Crews.PlanningCenter.Api;
using Crews.PlanningCenter.Calendar.Models.Entities;
using JsonApiFramework.JsonApi;
using JsonApiFramework.ServiceModel.Configuration;

namespace Crews.PlanningCenter.Calendar;

public class CalendarDocumentContext : PlanningCenterDocumentContext
{
	public CalendarDocumentContext() : base() { }
	public CalendarDocumentContext(Document document) : base(document) { }

	protected override void OnServiceModelCreating(IServiceModelBuilder serviceModelBuilder)
	{
		base.OnServiceModelCreating(serviceModelBuilder);
		serviceModelBuilder.Configurations.Add(new AttachmentConfiguration());
	}

	class AttachmentConfiguration : ResourceTypeBuilder<Attachment>
	{

	}
}
