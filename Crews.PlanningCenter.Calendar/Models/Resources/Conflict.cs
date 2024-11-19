
using Crews.PlanningCenter.Api.Extensions;
using Crews.PlanningCenter.Api.Models.Resources;
using Crews.PlanningCenter.Api.Models.Resources.Querying;
using Crews.PlanningCenter.Calendar.Models.Entities;
using Crews.PlanningCenter.Calendar.Models.Resources.Querying;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="Conflict"/> resource.
/// </summary>
public class ConflictResource 
	: CalendarSingletonResource<Conflict, ConflictResource>, 
	INamedApiResource, 
	IIncludable<ConflictResource, ConflictIncludable>
{
	/// <inheritdoc />
	public static string ApiName => "conflict";

	public PersonResource ResolvedBy => new(Uri.SafelyAppendPath("resolved_by"), Client);

	public ResourceResource Resource => new(Uri.SafelyAppendPath("resource"), Client);

	public EventResource Winner => new(Uri.SafelyAppendPath("winner"), Client);

	internal ConflictResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="Conflict"/> resources.
/// </summary>
public class ConflictResourceCollection
	: CalendarPaginatedResource<Conflict, ConflictResourceCollection, ConflictResource>, 
	INamedApiResource,
	IIncludable<ConflictResource, ConflictIncludable>
	IOrderable<ConflictResourceCollection, ConflictOrderable>, 
	IFilterable<ConflictResourceCollection, ConflictFilterable>
{
	/// <inheritdoc />
	public static string ApiName => "conflicts";

	internal ConflictResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
