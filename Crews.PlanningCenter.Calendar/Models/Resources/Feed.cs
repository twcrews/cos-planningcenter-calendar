using Crews.PlanningCenter.Api.Models.Resources;
using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="Feed"/> resource.
/// </summary>
public class FeedResource : CalendarSingletonResource<Feed, FeedResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "feed";
	
	internal FeedResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="Feed"/> resources.
/// </summary>
public class FeedResourceCollection 
	: CalendarPaginatedResource<Feed, FeedResourceCollection, FeedResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "feeds";
	
	internal FeedResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
