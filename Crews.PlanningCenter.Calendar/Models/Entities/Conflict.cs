namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// A conflict between two events caused by overlapping event resource requests.
/// </summary>
public class Conflict
{
	/// <summary>
	/// Related <see cref="Resource"/> resource.
	/// </summary>
	public string? ResourceID { get; set; }

	/// <summary>
	/// Related <see cref="Person"/> resource.
	/// </summary>
	public string? ResolvedByID { get; set; }

	/// <summary>
	/// Related <see cref="Event"/> resource.
	/// </summary>
	public string? WinnerID { get; set; }

	/// <summary>
	/// Unique identifier for the conflict.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// UTC time at which the conflict was created.
	/// </summary>
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// Additional information about the conflict or resolution.
	/// </summary>
	public string? Note { get; set; }

	/// <summary>
	/// UTC time at which the conflict was resolved.
	/// </summary>
	public DateTime? ResolvedAt { get; set; }

	/// <summary>
	/// UTC time at which the conflict was updated.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }
}
