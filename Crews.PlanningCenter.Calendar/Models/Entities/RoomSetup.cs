using Crews.PlanningCenter.Calendar.Models.Entities.Values;

namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// A diagram and list of suggested resources useful for predefined room setups.
/// </summary>
public class RoomSetup
{
	/// <summary>
	/// Related <see cref="RoomSetup"/> resource.
	/// </summary>
	public string? RoomSetupID { get; set; }

	/// <summary>
	/// Related <see cref="Resource"/> resource.
	/// </summary>
	public string? ContainingResourceID { get; set; }

	/// <summary>
	/// Unique identifier for the room setup.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// UTC time at which the room setup was created.
	/// </summary>
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// The name of the room setup.
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// UTC time at which the room setup was updated.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }

	/// <summary>
	/// A description of the room setup.
	/// </summary>
	public string? Description { get; set; }

	/// <summary>
	/// An object containing <see cref="RoomSetupDiagram.Url"/> and <see cref="RoomSetupDiagram.Thumbnail"/>. 
	/// <see cref="RoomSetupDiagram.Url"/> is path to where room setup is stored. <see cref="RoomSetupDiagram.Thumbnail"/>
	/// contains <see cref="DiagramThumbnail.Url"/> path to where thumbnail is stored.
	/// </summary>
	public RoomSetupDiagram? Diagram { get; set; }

	/// <summary>
	/// Path to where room setup is stored.
	/// </summary>
	public Uri? DiagramUrl { get; set; }

	/// <summary>
	/// Path to where thumbnail version of room setup is stored.
	/// </summary>
	public Uri? DiagramThumbnailUrl { get; set; }
}
