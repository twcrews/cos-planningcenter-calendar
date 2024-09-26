using Crews.PlanningCenter.Calendar.Models.Entities.Values;

namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// A room or resource that can be requested for use as part of an event.
/// </summary>
public class Resource
{
	/// <summary>
	/// Unique identifier for the room or resource.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// UTC time at which the room or resource was created.
	/// </summary>
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// The type of resource, can either be <c>Room</c>. or <c>Resource</c>.
	/// </summary>
	public ResourceKind? Kind { get; set; }

	/// <summary>
	/// The name of the room or resource.
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// The serial number of the resource.
	/// </summary>
	public string? SerialNumber { get; set; }

	/// <summary>
	/// UTC time at which the room or resource was updated.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }

	/// <summary>
	/// Description of the room or resource.
	/// </summary>
	public string? Description { get; set; }

	/// <summary>
	/// UTC time at which the resource expires.
	/// </summary>
	public DateTime? ExpiresAt { get; set; }

	/// <summary>
	/// Where the resource is normally kept.
	/// </summary>
	public string? HomeLocation { get; set; }

	/// <summary>
	/// Path to where resource image is stored.
	/// </summary>
	public Uri? Image { get; set; }

	/// <summary>
	/// The quantity of the resource.
	/// </summary>
	public int? Quantity { get; set; }

	/// <summary>
	/// A string representing the location of the resource if it is nested within a folder. Each parent folder is 
	/// separated by <c>/</c>.
	/// </summary>
	public string? PathName { get; set; }
}
