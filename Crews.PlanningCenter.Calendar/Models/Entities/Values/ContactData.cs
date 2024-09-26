namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents a person's contact data.
/// </summary>
public class ContactData
{
	/// <summary>
	/// Contact email addresses.
	/// </summary>
	public IEnumerable<EmailAddress>? EmailAddresses { get; set; }

	/// <summary>
	/// Contact physical addresses.
	/// </summary>
	public IEnumerable<PhysicalAddress>? Addresses { get; set; }

	/// <summary>
	/// Contact phone numbers.
	/// </summary>
	public IEnumerable<PhoneNumber>? PhoneNumbers { get; set; }
}
