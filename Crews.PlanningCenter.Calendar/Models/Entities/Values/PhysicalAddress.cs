namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents a physical address and its related information.
/// </summary>
public struct PhysicalAddress
{
	/// <summary>
	/// The address's street number and/or name.
	/// </summary>
	public required string Street { get; set; }

	/// <summary>
	/// The address's primary additional street information.
	/// </summary>
	public string? StreetLine1 { get; set; }

	/// <summary>
	/// The address's secondary additional street information.
	/// </summary>
	public string? StreetLine2 { get; set; }

	/// <summary>
	/// The address's containing city.
	/// </summary>
	public string? City { get; set; }

	/// <summary>
	/// The address's containing state or province.
	/// </summary>
	public string? State { get; set; }

	/// <summary>
	/// The address's zip code.
	/// </summary>
	public string? Zip { get; set; }

	/// <summary>
	/// The address's country code.
	/// </summary>
	public string? CountryCode { get; set; }

	/// <summary>
	/// The address's location as it pertains to its owner; i.e. 'Home' or 'Work'.
	/// </summary>
	public string? Location { get; set; }

	/// <summary>
	/// Indicates whether this address is the primary address for its owner.
	/// </summary>
	public bool? Primary { get; set; }
}
