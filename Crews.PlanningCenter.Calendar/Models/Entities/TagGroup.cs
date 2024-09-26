namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// A grouping of tags for organizational purposes.
/// </summary>
public class TagGroup
{
	/// <summary>
	/// Unique identifier for the tag group.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// UTC time at which the tag group was created.
	/// </summary>
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// The name of the tag group.
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// UTC time at which the tag group was updated.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }

	/// <summary>
	/// <c>true</c> indicates tag from this tag group must be applied when creating an event.
	/// </summary>
	public bool? Required { get; set; }
}
