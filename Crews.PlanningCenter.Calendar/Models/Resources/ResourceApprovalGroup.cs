using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="ResourceApprovalGroup"/> resource.
/// </summary>
public class ResourceApprovalGroupResource 
	: CalendarSingletonResource<ResourceApprovalGroup, ResourceApprovalGroupResource>
{
	internal ResourceApprovalGroupResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="ResourceApprovalGroup"/> resources.
/// </summary>
public class ResourceApprovalGroupResourceCollection 
	: CalendarPaginatedResource<ResourceApprovalGroup, ResourceApprovalGroupResourceCollection, ResourceApprovalGroupResource>
{
	internal ResourceApprovalGroupResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
