namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// Start and end times for each event instance. In the Calendar UI, these are represented under the "Schedule" section 
/// and may include "Setup" and "Teardown" times for the instance.
/// </summary>
public class EventTime
{
	/// <summary>
	/// Related <see cref="Event"/> resource.
	/// </summary>
	public string? EventID { get; set; }

	/// <summary>
	/// Unique identifier for the event time.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// UTC time at which the event time ends.
	/// </summary>
	public DateTime? EndsAt { get; set; }

	/// <summary>
	/// UTC time at which the event time starts.
	/// </summary>
	public DateTime? StartsAt { get; set; }

	/// <summary>
	/// Name of the event time.
	/// </summary>
	/// <remarks>
	/// <b>NOTE</b>: In the Planning Center API documentation, <see cref="Name"/> is 
	/// <see href="https://developer.planning.center/docs/#/apps/calendar/2022-07-07/vertices/event_time%23attributes">
	/// incorrectly
	/// </see> given the <see cref="DateTime"/> type.
	/// <br/><br/>
	/// The actual type returned by the API is <see cref="string"/>.
	/// </remarks>
	public string? Name { get; set; }

	/// <summary>
	/// Set to <c>true</c> if the time is visible on kiosk.
	/// </summary>
	public bool? VisibleOnKiosks { get; set; }
	
	/// <summary>
	/// Set to <c>true</c> if the time is visible on widget or iCal.
	/// </summary>
	public bool? VisibleOnWidgetAndIcal { get; set; }
}
