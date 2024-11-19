using Crews.PlanningCenter.Api.Models.Resources;
using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="JobStatus"/> resource.
/// </summary>
public class JobStatusResource : CalendarSingletonResource<JobStatus, JobStatusResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "job_status";
	
	internal JobStatusResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="JobStatus"/> resources.
/// </summary>
public class JobStatusResourceCollection 
	: CalendarPaginatedResource<JobStatus, JobStatusResourceCollection, JobStatusResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "job_statuses";
	
	internal JobStatusResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
