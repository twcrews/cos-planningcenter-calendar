using Crews.PlanningCenter.Api.Models.Resources;
using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="EventConnection"/> resource.
/// </summary>
public class EventConnectionResource 
	: CalendarSingletonResource<EventConnection, EventConnectionResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "event_connection";

	public EventResource Event => GetNamedAssociated<EventResource>();

	public EventTimeResourceCollection EventTimes => GetNamedAssociated<EventTimeResourceCollection>();
	
	internal EventConnectionResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="EventConnection"/> resources.
/// </summary>
public class EventConnectionResourceCollection 
	: CalendarPaginatedResource<EventConnection, EventConnectionResourceCollection, EventConnectionResource>, 
	INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "event_connections";
	
	internal EventConnectionResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
