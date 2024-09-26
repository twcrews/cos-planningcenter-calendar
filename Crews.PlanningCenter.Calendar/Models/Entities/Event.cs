using Crews.PlanningCenter.Calendar.Models.Entities.Values;

namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// May contain information such as who owns the event, visibility on Church Center and a public-facing summary.
/// </summary>
public class Event
{
	/// <summary>
	/// Related <see cref="Person"/> resource.
	/// </summary>
	public string? OwnerID { get; set; }

	/// <summary>
	/// Unique identifier for the event.
	/// </summary>
	public required string ID { get; set; }

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
	/// UTC time at which the event was created.
	/// </summary>
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// A rich text public-facing summary of the event.
	/// </summary>
	public string? Description { get; set; }

	/// <summary>
	/// <list type="bullet">
  ///   <item>true indicates the event is featured on Church Center</item>
  ///   <item>false indicates the event is not featured on Church Center</item>
	/// </list>
	/// </summary>
	public bool? Featured { get; set; }

	/// <summary>
	/// Path to where the event image is stored.
	/// </summary>
	public Uri? ImageUrl { get; set; }

	/// <summary>
	/// The name of the event.
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// Calculated by taking the sum of the <see cref="PercentApproved"/> for all future <c>ReservationBlock</c>s and 
	/// dividing that by the <c>count</c> of all future <c>ReservationBlock</c>s. If there are no future 
	/// <c>ReservationBlock</c>s, returns <c>100</c>.
	/// </summary>
	public int? PercentApproved { get; set; }

	/// <summary>
	/// Calculated by taking the sum of the <see cref="PercentRejected"/> for all future <c>ReservationBlock</c>s and 
	/// dividing that by the <c>count</c> of all future <c>ReservationBlock</c>s. If there are no future 
	/// <c>ReservationBlock</c>s, returns <c>0</c>.
	/// </summary>
	public int? PercentRejected { get; set; }

	/// <summary>
	/// The registration URL for the event.
	/// </summary>
	public Uri? RegistrationUrl { get; set; }

	/// <summary>
	/// A plain text public-facing summary of the event.
	/// </summary>
	public string? Summary { get; set; }

	/// <summary>
	/// UTC time at which the event was updated.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }

	/// <summary>
	/// <list type="bullet">
  ///   <item><c>true</c> indicates the event Church Center visibility is set to 'Published'</item>
  ///   <item><c>false</c> indicates the event Church Center visibility is set to 'Hidden'</item>
	/// </list>
	/// </summary>
	public bool? VisibleInChurchCenter { get; set; }
}
