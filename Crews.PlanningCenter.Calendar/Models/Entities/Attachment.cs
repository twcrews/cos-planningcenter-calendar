namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// An uploaded file attached to an event.
/// </summary>
public class Attachment
{
	/// <summary>
	/// Related <see cref="Event"/> resource.
	/// </summary>
	public string? EventID { get; set; }

	/// <summary>
	/// Unique identifier for the attachment.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// MIME type of the attachment.
	/// </summary>
	public string? ContentType { get; set; }

	/// <summary>
	/// UTC time at which the attachment was created.
	/// </summary>
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// Description of the attachment.
	/// </summary>
	public string? Description { get; set; }

	/// <summary>
	/// File size in bytes.
	/// </summary>
	public int? FileSize { get; set; }

	/// <summary>
	/// Set to the file name if not provided.
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// UTC time at which the attachment was updated.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }

	/// <summary>
	/// Path to where the attachment is stored.
	/// </summary>
	public Uri? Url { get; set; }
}
