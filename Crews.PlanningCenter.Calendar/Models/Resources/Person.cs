using Crews.PlanningCenter.Api.Models.Resources;
using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="Person"/> resource.
/// </summary>
public class PersonResource : CalendarSingletonResource<Person, PersonResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "person";
	
	internal PersonResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="Person"/> resources.
/// </summary>
public class PersonResourceCollection 
	: CalendarPaginatedResource<Person, PersonResourceCollection, PersonResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "people";
	
	internal PersonResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
