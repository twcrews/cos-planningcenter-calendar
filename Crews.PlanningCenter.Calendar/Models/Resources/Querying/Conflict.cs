namespace Crews.PlanningCenter.Calendar.Models.Resources.Querying;

/// <summary>
/// Includable resource types for <see cref="ConflictResource"/>.
/// </summary>
public enum ConflictIncludable
{
	/// <summary>
	/// Includable <see cref="PersonResource"/>.
	/// </summary>
	ResolvedBy,
	
	/// <summary>
	/// Includable <see cref="ResourceResource"/>.
	/// </summary>
	Resource,

	/// <summary>
	/// Includable <see cref="EventResource"/>.
	/// </summary>
	Winner
}

/// <summary>
/// Orderable attributes for <see cref="ConflictResource"/>.
/// </summary>
public enum ConflictOrderable
{
	/// <summary>
	/// Order by <see cref="Entities.Conflict.ResolvedAt"/>
	/// </summary>
	ResolvedAt
}

/// <summary>
/// Filters for <see cref="ConflictResource"/>.
/// </summary>
public enum ConflictFilterable
{
	/// <summary>
	/// Filter by unresolved.
	/// </summary>
	Unresolved,

	/// <summary>
	/// Filter by resolved.
	/// </summary>
	Resolved,

	/// <summary>
	/// Filter by future.
	/// </summary>
	Future
}