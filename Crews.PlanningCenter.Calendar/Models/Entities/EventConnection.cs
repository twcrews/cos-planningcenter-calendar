using Crews.PlanningCenter.Calendar.Models.Entities.Values;

namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// A connection between a Calendar event and a record in another product.
/// </summary>
public class EventConnection
{
	/// <summary>
	/// Related <see cref="Event"/> resource.
	/// </summary>
	public string? EventID { get; set; }

	/// <summary>
	/// Planning Center provides no description for this item.
	/// </summary>
	public required string ID { get; set; }
	
	/// <summary>
	/// Unique identifier for the connected record.
	/// </summary>
	public string? ConnectedToID { get; set; }

	/// <summary>
	/// Name of the record that the event is connected to.
	/// </summary>
	public string? ConnectedToName { get; set; }
	
	/// <summary>
	/// Currently we support <c>signup</c>, <c>group</c>, <c>event</c>, and <c>service_type</c>.
	/// </summary>
	public ConnectionType? ConnectedToType { get; set; }
	
	/// <summary>
	/// Currently we support <c>registrations</c>, <c>groups</c>, <c>check-ins</c>, and <c>services</c>.
	/// </summary>
	public ConnectedProduct? ProductName { get; set; }

	/// <summary>
	/// A link to the connected record.
	/// </summary>
	public Uri? ConnectedToUrl { get; set; }
}
