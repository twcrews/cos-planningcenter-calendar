using Crews.PlanningCenter.Api.Models.Resources;
using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="EventResourceRequest"/> resource.
/// </summary>
public class EventResourceRequestResource
	: CalendarSingletonResource<EventResourceRequest, EventResourceRequestResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "event_resource_request";
	
	internal EventResourceRequestResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="EventResourceRequest"/> resources.
/// </summary>
public class EventResourceRequestResourceCollection : CalendarPaginatedResource<
	EventResourceRequest, 
	EventResourceRequestResourceCollection, 
	EventResourceRequestResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "event_resource_requests";
	
	internal EventResourceRequestResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
