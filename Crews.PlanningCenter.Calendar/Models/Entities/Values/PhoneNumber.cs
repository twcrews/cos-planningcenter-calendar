namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents a phone number and its related information.
/// </summary>
public struct PhoneNumber
{
	/// <summary>The phone number's value. </summary>
	/// <remarks><b>WARNING</b>: The format is not guaranteed to be standardized; parse with care.</remarks>
	public required string Number { get; set; }

	/// <summary>
	/// The carrier for this number; i.e. 'Verizon'.
	/// </summary>
	public string? Carrier { get; set; }

	/// <summary>
	/// The location of the phone number as it pertains to its owner; i.e. 'Mobile' or 'Home'.
	/// </summary>
	public string? Location { get; set; }

	/// <summary>
	/// Indicates whether this phone number is the primary phone number for its owner.
	/// </summary>
	public bool? Primary { get; set; }
}
