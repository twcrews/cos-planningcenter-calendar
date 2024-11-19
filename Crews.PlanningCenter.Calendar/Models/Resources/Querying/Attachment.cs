namespace Crews.PlanningCenter.Calendar.Models.Resources.Querying;

/// <summary>
/// Includable resource types for <see cref="AttachmentResource"/>.
/// </summary>
public enum AttachmentIncludable
{
	/// <summary>
	/// Includable <see cref="EventResource"/>.
	/// </summary>
	Event
}

/// <summary>
/// Orderable attributes for <see cref="AttachmentResource"/>.
/// </summary>
public enum AttachmentOrderable
{
	/// <summary>
	/// Order by <see cref="Entities.Attachment.ContentType"/>.
	/// </summary>
	ContentType,

	/// <summary>
	/// Order by <see cref="Entities.Attachment.CreatedAt"/>.
	/// </summary>
	CreatedAt,

	/// <summary>
	/// Order by <see cref="Entities.Attachment.Description"/>.
	/// </summary>
	Description,

	/// <summary>
	/// Order by <see cref="Entities.Attachment.FileSize"/>.
	/// </summary>
	FileSize,

	/// <summary>
	/// Order by <see cref="Entities.Attachment.Name"/>.
	/// </summary>
	Name,

	/// <summary>
	/// Order by <see cref="Entities.Attachment.UpdatedAt"/>.
	/// </summary>
	UpdatedAt
}

/// <summary>
/// Queryable attributes for <see cref="AttachmentResource"/>.
/// </summary>
public enum AttachmentQueryable
{
	/// <summary>
	/// Query by <see cref="Entities.Attachment.ContentType"/>.
	/// </summary>
	ContentType,

	/// <summary>
	/// Query by <see cref="Entities.Attachment.CreatedAt"/>.
	/// </summary>
	CreatedAt,

	/// <summary>
	/// Query by <see cref="Entities.Attachment.Description"/>.
	/// </summary>
	Description,

	/// <summary>
	/// Query by <see cref="Entities.Attachment.FileSize"/>.
	/// </summary>
	FileSize,

	/// <summary>
	/// Query by <see cref="Entities.Attachment.Name"/>.
	/// </summary>
	Name,

	/// <summary>
	/// Query by <see cref="Entities.Attachment.UpdatedAt"/>.
	/// </summary>
	UpdatedAt
}
