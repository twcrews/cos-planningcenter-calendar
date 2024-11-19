using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="Resource"/> resource.
/// </summary>
public class ResourceResource : CalendarSingletonResource<Resource, ResourceResource>
{
	internal ResourceResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="Resource"/> resources.
/// </summary>
public class ResourceResourceCollection 
	: CalendarPaginatedResource<Resource, ResourceResourceCollection, ResourceResource>
{
	internal ResourceResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
