namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// A specific booking of a room or resource for an event instance.
/// </summary>
public class ResourceBooking
{
	/// <summary>
	/// Related <see cref="Event"/> resource.
	/// </summary>
	public string? EventID { get; set; }
	
	/// <summary>
	/// Related <see cref="EventInstance"/> resource.
	/// </summary>
	public string? EventInstanceID { get; set; }

	/// <summary>
	/// Related <see cref="Resource"/> resource.
	/// </summary>
	public string? ResourceID { get; set; }

	/// <summary>
	/// Unique identifier for the booking.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// UTC time at which the booking was created.
	/// </summary>
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// UTC time at which usage of the booked room or resource ends.
	/// </summary>
	public DateTime? EndsAt { get; set; }

	/// <summary>
	/// UTC time at which usage of the booked room or resource starts.
	/// </summary>
	public DateTime? StartsAt { get; set; }

	/// <summary>
	/// UTC time at which the booking was updated.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }

	/// <summary>
	/// The quantity of the rooms or resources booked.
	/// </summary>
	public int? Quantity { get; set; }
}
