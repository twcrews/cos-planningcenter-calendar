using Crews.PlanningCenter.Api.Extensions;
using Crews.PlanningCenter.Api.Models.Resources;
using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="Event"/> resource.
/// </summary>
public class EventResource : CalendarSingletonResource<Event, EventResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "event";
	
	internal EventResource(Uri uri, HttpClient client) : base(uri, client) { }

	public AttachmentResourceCollection Attachments => new(Uri.SafelyAppendPath("attachments"), Client);

	public ConflictResourceCollection Conflicts => new(Uri.SafelyAppendPath("conflicts"), Client);

	public EventConnectionResourceCollection EventConnections => new(Uri.SafelyAppendPath("event_connections"), Client);

	public EventInstanceResourceCollection EventInstances => new(Uri.SafelyAppendPath("event_instances"), Client);

	public EventResourceRequestResourceCollection EventResourceRequests => new(Uri.SafelyAppendPath("event_resource_requests"), Client);
}

/// <summary>
/// A fetchable collection of <see cref="Event"/> resources.
/// </summary>
public class EventResourceCollection 
	: CalendarPaginatedResource<Event, EventResourceCollection, EventResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "events";
	
	internal EventResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
