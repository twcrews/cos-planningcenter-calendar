using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="TagGroup"/> resource.
/// </summary>
public class TagGroupResource : CalendarSingletonResource<TagGroup, TagGroupResource>
{
	internal TagGroupResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="TagGroup"/> resources.
/// </summary>
public class TagGroupResourceCollection 
	: CalendarPaginatedResource<TagGroup, TagGroupResourceCollection, TagGroupResource>
{
	internal TagGroupResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
