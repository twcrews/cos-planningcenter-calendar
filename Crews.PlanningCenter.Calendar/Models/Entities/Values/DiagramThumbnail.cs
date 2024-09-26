namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents the <see cref="RoomSetupDiagram.Thumbnail"/> property of <see cref="RoomSetup.Diagram"/>.
/// </summary>
public struct DiagramThumbnail
{
	/// <summary>
	/// Path to where thumbnail is stored.
	/// </summary>
	public Uri? Url { get; set; }
}
