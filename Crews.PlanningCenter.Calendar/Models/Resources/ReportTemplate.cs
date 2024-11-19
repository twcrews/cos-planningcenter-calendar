using Crews.PlanningCenter.Api.Models.Resources;
using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="ReportTemplate"/> resource.
/// </summary>
public class ReportTemplateResource 
	: CalendarSingletonResource<ReportTemplate, ReportTemplateResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "report_template";
	
	internal ReportTemplateResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="ReportTemplate"/> resources.
/// </summary>
public class ReportTemplateResourceCollection 
	: CalendarPaginatedResource<ReportTemplate, ReportTemplateResourceCollection, ReportTemplateResource>, 
	INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "report_templates";
	
	internal ReportTemplateResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
