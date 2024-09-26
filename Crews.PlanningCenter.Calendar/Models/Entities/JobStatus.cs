namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// Planning Center provides no description for this item.
/// </summary>
public class JobStatus
{
	/// <summary>
	/// Planning Center provides no description for this item.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// Planning Center provides no description for this item.
	/// </summary>
	public int? Retries { get; set; }

	/// <summary>
	/// Planning Center provides no description for this item.
	/// </summary>
	public Dictionary<string, object>? Errors { get; set; }

	/// <summary>
	/// Planning Center provides no description for this item.
	/// </summary>
	public string? Message { get; set; }

	/// <summary>
	/// Planning Center provides no description for this item.
	/// </summary>
	public DateTime? StartedAt { get; set; }

	/// <summary>
	/// Planning Center provides no description for this item.
	/// </summary>
	public string? Status { get; set; }
}
