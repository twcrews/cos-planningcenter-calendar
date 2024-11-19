using Crews.PlanningCenter.Api.Models.Resources;
using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="ResourceSuggestion"/> resource.
/// </summary>
public class ResourceSuggestionResource 
	: CalendarSingletonResource<ResourceSuggestion, ResourceSuggestionResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "resource_suggestion";
	
	internal ResourceSuggestionResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="ResourceSuggestion"/> resources.
/// </summary>
public class ResourceSuggestionResourceCollection 
	: CalendarPaginatedResource<ResourceSuggestion, ResourceSuggestionResourceCollection, ResourceSuggestionResource>,
	INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "resource_suggestions";

		internal ResourceSuggestionResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
