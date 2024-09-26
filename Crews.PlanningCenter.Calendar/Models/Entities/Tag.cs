namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// An organizational tag that can be applied to events. Applied tags can be used to filter events on the calendar or 
/// filter events for reports, iCal feeds, kiosk, and the widget.
/// </summary>
public class Tag
{
	/// <summary>
	/// Unique identifier for the tag.
	/// </summary>
	public string? ID { get; set; }

	/// <summary>
	/// <c>true</c> indicates that this tag is used as a category on Church Center.
	/// </summary>
	public bool? ChurchCenterCategory { get; set; }

	/// <summary>
	/// Hex color code of the tag.
	/// </summary>
	public string? Color { get; set; }

	/// <summary>
	/// UTC time at which the tag was created.
	/// </summary>
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// The tag name.
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// If the tag belongs to a TagGroup, position indicates place in list within TagGroup in the UI. If the tag does not 
	/// belong to a TagGroup, position indicates place in list under "Individual Tags" in the UI.
	/// </summary>
	public float? Position { get; set; }

	/// <summary>
	/// UTC time at which the tag was updated.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }
}
