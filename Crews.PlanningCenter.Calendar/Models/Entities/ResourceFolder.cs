using Crews.PlanningCenter.Calendar.Models.Entities.Values;

namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// An organizational folder containing rooms or resources.
/// </summary>
public class ResourceFolder
{
	/// <summary>
	/// Unique identifier for the folder.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// UTC time at which the folder was created.
	/// </summary>
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// The folder name.
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// UTC time at which the folder was updated.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }

	/// <summary>
	/// Planning Center provides no description for this item.
	/// </summary>
	public string? Ancestry { get; set; }

	/// <summary>
	/// The type of folder, can either be <c>Room</c> or <c>Resource</c>.
	/// </summary>
	public ResourceKind? Kind { get; set; }

	/// <summary>
	/// A string representing the location of the folder if it is nested. Each parent folder is separated by <c>/</c>.
	/// </summary>
	public string? PathName { get; set; }
}
