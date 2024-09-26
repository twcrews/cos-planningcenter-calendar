namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents a resource kind value on a Planning Center Calendar resource.
/// </summary>
public readonly struct ResourceKind
{
	private readonly string _value;

	/// <summary>
	/// Represents a Room resource.
	/// </summary>
	public static ResourceKind Room => new("Room");

	/// <summary>
	/// Represents a miscellaneous resource.
	/// </summary>
	public static ResourceKind Resource => new("Resource");

	/// <summary>
	/// Instantiates a <see cref="ResourceKind"/> with the default value of <c>Room</c>.
	/// </summary>
	public ResourceKind() => _value = "Room";

	/// <summary>
	/// Gets the string representation of the internal value of the <see cref="ResourceKind"/>.
	/// </summary>
	/// <returns>
	/// Either <c>Room</c> or <c>Resource</c>.
	/// </returns>
	public override string ToString() => _value;

	/// <summary>
	/// Attempts to parse the given <see cref="string"/> into its <see cref="ResourceKind"/> representation.
	/// </summary>
	/// <param name="value">The <see cref="string"/> to parse.</param>
	/// <exception cref="InvalidCastException">
	/// <paramref name="value"/> was not one of the allowed values of <c>Room</c> or <c>Resource</c> (case sensitive).
	/// </exception>
	public static implicit operator ResourceKind(string value) => new(ValidateAndCleanString(value));

	/// <summary>
	/// Equivalent to calling <see cref="ToString"/> on the <see cref="ResourceKind"/> instance.
	/// </summary>
	/// <param name="value">The <see cref="ResourceKind"/> instance to convert.</param>
	public static implicit operator string(ResourceKind value) => value.ToString();

	private ResourceKind(string value) => _value = value;

	private static string ValidateAndCleanString(string value)
	{
		string cleanValue = value.Trim();

		string[] allowedValues = ["Room", "Resource"];
		if (!allowedValues.Contains(cleanValue))
		{
			throw new InvalidCastException(
				"Value must be 'Room' or 'Resource' (case sensitive).");
		}

		return cleanValue;
	}
}
