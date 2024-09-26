using Crews.PlanningCenter.Calendar.Models.Entities.Values;

namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// A feed belonging to an organization.
/// </summary>
public class Feed
{
	/// <summary>
	/// Related <see cref="Person"/> resource.
	/// </summary>
	public string? EventOwnerID { get; set; }

	/// <summary>
	/// Planning Center provides no description for this item.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// Planning Center provides no description for this item.
	/// </summary>
	public bool? CanDelete { get; set; }

	/// <summary>
	/// Possible values: <c>hidden</c> or <c>published</c>.
	/// </summary>
	public PublishVisibility? DefaultChurchCenterVisibility { get; set; }

	/// <summary>
	/// Possible values: <c>registrations</c>, <c>groups</c>, <c>ical</c>, or <c>form</c>.
	/// </summary>
	public FeedType? FeedType { get; set; }

	/// <summary>
	/// Planning Center provides no description for this item.
	/// </summary>
	public DateTime? ImportedAt { get; set; }

	/// <summary>
	/// Planning Center provides no description for this item.
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// Planning Center provides no description for this item.
	/// </summary>
	public string? SourceID { get; set; }
}
