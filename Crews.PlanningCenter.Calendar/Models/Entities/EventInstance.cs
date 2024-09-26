namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// A specific occurrence of an event. If the event is recurring, <see cref="Recurrence"/> will be set and 
/// <see cref="RecurrenceDescription"/> will provide an overview of the recurrence pattern.
/// </summary>
public class EventInstance
{
	/// <summary>
	/// Related <see cref="Event"/> resource.
	/// </summary>
	public string? EventID { get; set; }

	/// <summary>
	/// Unique identifier for the event instance.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// Indicates whether event instance lasts all day.
	/// </summary>
	public bool? AllDayEvent { get; set; }

	/// <summary>
	/// Compact representation of event instance's recurrence pattern.
	/// </summary>
	public string? CompactRecurrenceDescription { get; set; }

	/// <summary>
	/// UTC time at which the event instance was created.
	/// </summary>
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// UTC time at which the event instance ends.
	/// </summary>
	public DateTime? EndsAt { get; set; }

	/// <summary>
	/// Representation of where the event instance takes place.
	/// </summary>
	public string? Location { get; set; }

	/// <summary>
	/// For a recurring event instance, the interval of how often the event instance occurs.
	/// </summary>
	public string? Recurrence { get; set; }

	/// <summary>
	/// Longer description of the event instance's recurrence pattern.
	/// </summary>
	public string? RecurrenceDescription { get; set; }

	/// <summary>
	/// UTC time at which the event instance starts.
	/// </summary>
	public DateTime? StartsAt { get; set; }

	/// <summary>
	/// UTC time at which the event instance was updated.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }

	/// <summary>
	/// The URL for the event on Church Center.
	/// </summary>
	public Uri? ChurchCenterUrl { get; set; }

	/// <summary>
	/// Publicly visible start time.
	/// </summary>
	public string? PublishedStartsAt { get; set; }

	/// <summary>
	/// Publicly visible end time.
	/// </summary>
	public string? PublishedEndsAt { get; set; }
}
