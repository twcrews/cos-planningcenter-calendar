namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents an active/inactive status value on a Planning Center Calendar resource.
/// </summary>
public readonly struct ActiveStatus
{
	private readonly string _value;

	/// <summary>
	/// Represents an active status.
	/// </summary>
	public static ActiveStatus Active => new("active");

	/// <summary>
	/// Represents a pending status.
	/// </summary>
	public static ActiveStatus Pending => new("pending");

	/// <summary>
	/// Represents an inactive status.
	/// </summary>
	public static ActiveStatus Inactive => new("inactive");

	/// <summary>
	/// Gets the string representation of the internal value of the <see cref="ActiveStatus"/>.
	/// </summary>
	/// <returns>
	/// Either <c>active</c>, <c>pending</c>, or <c>inactive</c>.
	/// </returns>
	public override string ToString() => _value;

	/// <summary>
	/// Attempts to parse the given <see cref="string"/> into its <see cref="ActiveStatus"/> representation.
	/// </summary>
	/// <param name="value">The <see cref="string"/> to parse.</param>
	/// <exception cref="InvalidCastException">
	/// <paramref name="value"/> was not one of the allowed values of <c>active</c>, <c>pending</c>, or <c>inactive</c> 
	/// (case insensitive).
	/// </exception>
	public static implicit operator ActiveStatus(string value) => new(ValidateAndCleanString(value));

	/// <summary>
	/// Equivalent to calling <see cref="ToString"/> on the <see cref="ActiveStatus"/> instance.
	/// </summary>
	/// <param name="value">The <see cref="ActiveStatus"/> instance to convert.</param>
	public static implicit operator string(ActiveStatus value) => value.ToString();

	private ActiveStatus(string value) => _value = value;

	private static string ValidateAndCleanString(string value)
	{
		string cleanValue = value.Trim().ToLowerInvariant();

		string[] allowedValues = ["active", "pending", "inactive"];
		if (!allowedValues.Contains(cleanValue))
		{
			throw new InvalidCastException(
				"Value must be 'active', 'pending', or 'inactive' (case insensitive).");
		}

		return cleanValue;
	}
}
