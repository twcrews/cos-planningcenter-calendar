namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// A group of people that can be attached to a room or resource in order to require their approval for booking.
/// </summary>
public class ResourceApprovalGroup
{
	/// <summary>
	/// Unique identifier for the approval group.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// UTC time at which the approval group was created.
	/// </summary>
	public DateTime? CreatedAt { get; set; }
	
	/// <summary>
	/// Name of the approval group.
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// UTC time at which the approval group was updated.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }

	/// <summary>
	/// Only available when requested with the <c>?fields</c> param.
	/// </summary>
	public int? FormCount { get; set; }

	/// <summary>
	/// The number of resources in the approval group. Only available when requested with the <c>?fields</c> param.
	/// </summary>
	public int? ResourceCount { get; set; }

	/// <summary>
	/// The number of rooms in the approval group. Only available when requested with the <c>?fields</c> param.
	/// </summary>
	public int? RoomCount { get; set; }
}
