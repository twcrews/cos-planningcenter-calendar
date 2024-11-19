using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="ResourceQuestion"/> resource.
/// </summary>
public class ResourceQuestionResource : CalendarSingletonResource<ResourceQuestion, ResourceQuestionResource>
{
	internal ResourceQuestionResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="ResourceQuestion"/> resources.
/// </summary>
public class ResourceQuestionResourceCollection : CalendarPaginatedResource<ResourceQuestion, ResourceQuestionResourceCollection, ResourceQuestionResource>
{
	internal ResourceQuestionResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
