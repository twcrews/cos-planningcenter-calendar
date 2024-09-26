namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents the diagram of a <see cref="RoomSetup"/> resource.
/// </summary>
public struct RoomSetupDiagram
{
	/// <summary>
	/// Path to where room setup is stored.
	/// </summary>
	public Uri? Url { get; set; }

	/// <summary>
	/// Contains <see cref="DiagramThumbnail.Url"/> path to where thumbnail is stored.
	/// </summary>
	public DiagramThumbnail? Thumbnail { get; set; }
}
