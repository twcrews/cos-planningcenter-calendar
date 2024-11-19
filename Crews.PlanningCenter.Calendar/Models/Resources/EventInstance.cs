using Crews.PlanningCenter.Api.Models.Resources;
using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="EventInstance"/> resource.
/// </summary>
public class EventInstanceResource : CalendarSingletonResource<EventInstance, EventInstanceResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "event_instance";
	
	internal EventInstanceResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="EventInstance"/> resources.
/// </summary>
public class EventInstanceResourceCollection
	: CalendarPaginatedResource<EventInstance, EventInstanceResourceCollection, EventInstanceResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "event_instances";
	
	internal EventInstanceResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
