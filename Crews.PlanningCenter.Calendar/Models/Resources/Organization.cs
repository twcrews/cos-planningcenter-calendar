using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="Organization"/> resource.
/// </summary>
public class OrganizationResource : CalendarSingletonResource<Organization, OrganizationResource>
{
	internal OrganizationResource(Uri uri, HttpClient client) : base(uri, client) { }
}
