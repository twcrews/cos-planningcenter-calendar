using Crews.PlanningCenter.Calendar.Models.Entities.Values;

namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// A room or resource request for a specific event.
/// </summary>
public class EventResourceRequest
{
	/// <summary>
	/// Related <see cref="Event"/> resource.
	/// </summary>
	public string? EventID { get; set; }
	
	/// <summary>
	/// Related <see cref="Resource"/> resource.
	/// </summary>
	public string? ResourceID { get; set; }

	/// <summary>
	/// Related <see cref="EventResourceRequest"/> resource.
	/// </summary>
	public string? EventResourceRequestID { get; set; }
	
	/// <summary>
	/// Related <see cref="Person"/> resource.
	/// </summary>
	public string? CreatedByID { get; set; }
	
	/// <summary>
	/// Related <see cref="Person"/> resource.
	/// </summary>
	public string? UpdatedByID { get; set; }
	
	/// <summary>
	/// Related <see cref="RoomSetup"/> resource.
	/// </summary>
	public string? RoomSetupID { get; set; }

	/// <summary>
	/// Unique identifier for the request.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// Whether or not an email has been sent to request approval.
	/// </summary>
	public bool? ApprovalSent { get; set; }
	
	/// <summary>
	/// Possible values:
	/// <list type="bullet">
  ///   <item><c>A</c>: approved.</item>
  ///   <item><c>P</c>: pending.</item>
  ///   <item><c>R</c>: rejected.</item>
	/// </list>
	/// </summary>
	public ApprovalStatus? ApprovalStatus { get; set; }

	/// <summary>
	/// UTC time at which request was created.
	/// </summary>
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// UTC time at which request was updated.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }

	/// <summary>
	/// Additional information about the room or resource request.
	/// </summary>
	public string? Notes { get; set; }

	/// <summary>
	/// How many of the rooms or resources are being requested.
	/// </summary>
	public int? Quantity { get; set; }
}
