using Crews.PlanningCenter.Api.Models.Resources;
using Crews.PlanningCenter.Calendar.Models.Entities;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="RequiredApproval"/> resource.
/// </summary>
public class RequiredApprovalResource 
	: CalendarSingletonResource<RequiredApproval, RequiredApprovalResource>, INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "required_approval";
	
	internal RequiredApprovalResource(Uri uri, HttpClient client) : base(uri, client) { }
}

/// <summary>
/// A fetchable collection of <see cref="RequiredApproval"/> resources.
/// </summary>
public class RequiredApprovalResourceCollection 
	: CalendarPaginatedResource<RequiredApproval, RequiredApprovalResourceCollection, RequiredApprovalResource>,
	INamedApiResource
{
	/// <inheritdoc />
	public static string ApiName => "required_approvals";
	
		internal RequiredApprovalResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }
}
