using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="RoomSetup"/> resource.
/// </summary>
public class RoomSetupResource : CalendarSingletonResource<RoomSetup, RoomSetupResource>
{
	internal RoomSetupResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="RoomSetup"/> resources.
/// </summary>
public class RoomSetupResourceCollection 
	: CalendarPaginatedResource<RoomSetup, RoomSetupResourceCollection, RoomSetupResource>
{
	internal RoomSetupResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
