using Crews.PlanningCenter.Api.Models.Resources.PlanningCenter;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

internal abstract class CalendarFetchableResource<TResource, TSelf>(Uri uri, HttpClient client)
	: PlanningCenterFetchableResource<TSelf>(uri, client)
	where TResource : class
	where TSelf: CalendarFetchableResource<TResource, TSelf> { }

/// <summary>
/// Represents a single fetchable resource in the Planning Center Calendar API.
/// </summary>
/// <typeparam name="TResource">The represented resource type.</typeparam>
/// <typeparam name="TSelf">
/// The type of the implementing class, used for statically typed chained method calls.
/// </typeparam>
public abstract class CalendarSingletonResource<TResource, TSelf>(Uri uri, HttpClient client) 
	: PlanningCenterSingletonFetchableResource<TResource, TSelf, CalendarDocumentContext>(uri, client) 
	where TResource : class 
	where TSelf : CalendarSingletonResource<TResource, TSelf> { }

/// <summary>
/// Represents a fetchable resource collection in the Planning Center Calendar API.
/// </summary>
/// <typeparam name="TResource">The represented resource type.</typeparam>
/// <typeparam name="TSelf">
/// The type of the implementing class, used for statically typed chained method calls.
/// </typeparam>
/// <typeparam name="TSingleton">The resource type of the elements contained in the collection.</typeparam>
public abstract class CalendarPaginatedResource<TResource, TSelf, TSingleton> 
	: PlanningCenterPaginatedFetchableResource<TResource, TSelf, TSingleton, CalendarDocumentContext>
	where TResource : class
	where TSelf : CalendarPaginatedResource<TResource, TSelf, TSingleton>
	where TSingleton : CalendarSingletonResource<TResource, TSingleton>
{
	internal CalendarPaginatedResource(Uri uri, HttpClient client) : base(uri, client) {}
}
