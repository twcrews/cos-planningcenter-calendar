using Crews.PlanningCenter.Api;
using JsonApiFramework.JsonApi;
using JsonApiFramework.ServiceModel.Configuration;

namespace Crews.PlanningCenter.Calendar;

class CalendarDocumentContext : PlanningCenterDocumentContext
{
	public CalendarDocumentContext() : base() { }
	public CalendarDocumentContext(Document document) : base(document) { }

	protected override void OnServiceModelCreating(IServiceModelBuilder serviceModelBuilder)
	{
		base.OnServiceModelCreating(serviceModelBuilder);
	}
}
