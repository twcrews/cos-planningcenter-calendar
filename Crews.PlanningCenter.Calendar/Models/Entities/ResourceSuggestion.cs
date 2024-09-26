namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// A resource and quantity suggested by a room setup.
/// </summary>
public class ResourceSuggestion
{
	/// <summary>
	/// Related <see cref="Resource"/> resource.
	/// </summary>
	public string? ResourceID { get; set; }

	/// <summary>
	/// Related <see cref="RoomSetup"/> resource.
	/// </summary>
	public string? RoomSetupID { get; set; }

	/// <summary>
	/// Unique identifier for the suggestion.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// UTC time at which the suggestion was created.
	/// </summary>
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// How many resources should be requested.
	/// </summary>
	public int? Quantity { get; set; }

	/// <summary>
	/// UTC time at which the suggestion was updated.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }
}
