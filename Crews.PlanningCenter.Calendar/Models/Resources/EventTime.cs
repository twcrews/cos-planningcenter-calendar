using Crews.PlanningCenter.Api.Models.Resources;
using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="EventTime"/> resource.
/// </summary>
public class EventTimeResource : CalendarSingletonResource<EventTime, EventTimeResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "event_time";
	
	internal EventTimeResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="EventTime"/> resources.
/// </summary>
public class EventTimeResourceCollection 
	: CalendarPaginatedResource<EventTime, EventTimeResourceCollection, EventTimeResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "event_times";
	
	internal EventTimeResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
