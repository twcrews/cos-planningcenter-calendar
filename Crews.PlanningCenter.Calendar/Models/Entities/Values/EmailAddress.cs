namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents an email address and its related information.
/// </summary>
public struct EmailAddress
{
	/// <summary>
	/// The email address value.
	/// </summary>
	public required string Address { get; set; }

	/// <summary>
	/// The location of the email address.
	/// </summary>
	public string? Location { get; set; }

	/// <summary>
	/// Indicates whether this email address is the primary address for its owner.
	/// </summary>
	public bool? Primary { get; set; }

	/// <summary>
	/// Indicates whether this email address is marked as blocked.
	/// </summary>
	public bool? Blocked { get; set; }
}
