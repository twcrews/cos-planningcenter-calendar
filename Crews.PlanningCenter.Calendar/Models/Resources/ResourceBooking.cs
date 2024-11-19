using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="ResourceBooking"/> resource.
/// </summary>
public class ResourceBookingResource : CalendarSingletonResource<ResourceBooking, ResourceBookingResource>
{
	internal ResourceBookingResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="ResourceBooking"/> resources.
/// </summary>
public class ResourceBookingResourceCollection 
	: CalendarPaginatedResource<ResourceBooking, ResourceBookingResourceCollection, ResourceBookingResource>
{
	internal ResourceBookingResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
