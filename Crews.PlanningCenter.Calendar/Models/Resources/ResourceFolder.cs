using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="ResourceFolder"/> resource.
/// </summary>
public class ResourceFolderResource : CalendarSingletonResource<ResourceFolder, ResourceFolderResource>
{
	internal ResourceFolderResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="ResourceFolder"/> resources.
/// </summary>
public class ResourceFolderResourceCollection 
	: CalendarPaginatedResource<ResourceFolder, ResourceFolderResourceCollection, ResourceFolderResource>
{
	internal ResourceFolderResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
