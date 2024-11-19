using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="Tag"/> resource.
/// </summary>
public class TagResource : CalendarSingletonResource<Tag, TagResource>
{
	internal TagResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="Tag"/> resources.
/// </summary>
public class TagResourceCollection 
	: CalendarPaginatedResource<Tag, TagResourceCollection, TagResource>
{
	internal TagResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
