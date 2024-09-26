using Crews.PlanningCenter.Calendar.Models.Entities.Values;

namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// The people in your organization with access to Calendar.
/// </summary>
public class Person
{
	/// <summary>
	/// Unique identifier for the person.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// UTC time at which the person was created.
	/// </summary>
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// The person's first name.
	/// </summary>
	public string? FirstName { get; set; }

	/// <summary>
	/// The person's last name.
	/// </summary>
	public string? LastName { get; set; }

	/// <summary>
	/// The person's middle name.
	/// </summary>
	public string? MiddleName { get; set; }

	/// <summary>
	/// UTC time at which the person was updated.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }

	/// <summary>
	/// Path to where the avatar image is stored.
	/// </summary>
	public Uri? AvatarUrl { get; set; }

	/// <summary>
	/// Indicates whether the person is a child.
	/// </summary>
	public bool? Child { get; set; }

	/// <summary>
	/// An object containing the person's contact data.
	/// This can include an array of <c>email_addresses</c>, <c>addresses</c> and <c>phone_numbers</c>.
	/// </summary>
	public ContactData? ContactData { get; set; }

	/// <summary>
	/// <c>M</c> indicates male, <c>F</c> indicates female.
	/// </summary>
	public Gender? Gender { get; set; }

	/// <summary>
	/// Indicates whether the person has access to Calendar.
	/// </summary>
	public bool? HasAccess { get; set; }

	/// <summary>
	/// Possible values:
	/// <list type="bullet">
  ///   <item><c>Mr.</c></item>
  ///   <item><c>Mrs.</c></item>
  ///   <item><c>Ms.</c></item>
  ///   <item><c>Miss</c></item>
  ///   <item><c>Dr.</c></item>
  ///   <item><c>Rev.</c></item>
	/// </list>
	/// </summary>
	public NamePrefix? NamePrefix { get; set; }

	/// <summary>
	/// Possible values:
	/// <list type="bullet">
  ///   <item><c>Jr.</c></item>
  ///   <item><c>Sr.</c></item>
  ///   <item><c>Ph.D.</c></item>
  ///   <item><c>II</c></item>
  ///   <item><c>III</c></item>
	/// </list>
	/// </summary>	
	public NameSuffix? NameSuffix { get; set; }

	/// <summary>
	/// If the person is a member of an approval group, the number of <see cref="EventResourceRequest"/>s needing 
	/// resolution. If <see cref="ResolvesConflicts"/> is <c>true</c>, the count will also include the number of 
	/// <see cref="Conflict"/>s needing resolution.
	/// </summary>
	public int? PendingRequestCount { get; set; }

	/// <summary>
	/// Integer that corresponds to the person's permissions in Calendar.
	/// </summary>
	public int? Permissions { get; set; }

	/// <summary>
	/// Indicates whether the person is able to resolve Conflicts.
	/// </summary>
	public bool? ResolvesConflicts { get; set; }

	/// <summary>
	/// Indicates whether the person is a Organization Administrator.
	/// </summary>
	public bool? SiteAdministrator { get; set; }

	/// <summary>
	/// Possible values:
	/// <list type="bullet">
  ///   <item><c>active</c>: The person is marked "active" in People.</item>
  ///   <item><c>inactive</c>: The person is marked "inactive" in People.</item>
	/// </list>
  /// Possible values: <c>active</c>, <c>pending</c>, or <c>inactive</c>.
	/// </summary>
	public ActiveStatus? Status { get; set; }

	/// <summary>
	/// Indicates whether the person can edit other people.
	/// </summary>
	public bool? CanEditPeople { get; set; }

	/// <summary>
	/// Indicates whether the person can edit resources.
	/// </summary>
	public bool? CanEditResources { get; set; }

	/// <summary>
	/// Indicates whether the person can edit rooms.
	/// </summary>
	public bool? CanEditRooms { get; set; }

	/// <summary>
	/// Event permissions for the person.
	/// </summary>
	public string? EventPermissionsType { get; set; }

	/// <summary>
	/// Indicates whether the person is a member of at least one approval group. Only available when requested with the 
	/// <c>?fields</c> param.
	/// </summary>
	public bool? MemberOfApprovalGroups { get; set; }

	/// <summary>
	/// The person's first name, last name, and name suffix.
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// People permissions for the person.
	/// </summary>
	public string? PeoplePermissionsType { get; set; }

	/// <summary>
	/// Room permissions for the person.
	/// </summary>
	public string? RoomPermissionsType { get; set; }

	/// <summary>
	/// Resource permissions for the person.
	/// </summary>
	public string? ResourcesPermissionsType { get; set; }
}
