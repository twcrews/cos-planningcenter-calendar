namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents a connected product name value on a Planning Center Calendar resource.
/// </summary>
public readonly struct ConnectedProduct
{
	private readonly string _value;

	/// <summary>
	/// Represents the Registrations product.
	/// </summary>
	public static ConnectedProduct Registrations => new("registrations");

	/// <summary>
	/// Represents the Groups product.
	/// </summary>
	public static ConnectedProduct Groups => new("groups");

	/// <summary>
	/// Represents the Check-ins product.
	/// </summary>
	public static ConnectedProduct CheckIns => new("check-ins");

	/// <summary>
	/// Represents the Services product.
	/// </summary>
	public static ConnectedProduct Services => new("services");

	/// <summary>
	/// Instantiates an <see cref="ConnectedProduct"/> with the default value of <c>registrations</c>.
	/// </summary>
	public ConnectedProduct() => _value = "registrations";

	/// <summary>
	/// Gets the string representation of the internal value of the <see cref="ConnectedProduct"/>.
	/// </summary>
	/// <returns>
	/// Either <c>registrations</c>, <c>groups</c>, <c>check-ins</c>, or <c>services</c>.
	/// </returns>
	public override string ToString() => _value;

	/// <summary>
	/// Attempts to parse the given <see cref="string"/> into its <see cref="ConnectedProduct"/> representation.
	/// </summary>
	/// <param name="value">The <see cref="string"/> to parse.</param>
	/// <exception cref="InvalidCastException">
	/// <paramref name="value"/> was not one of the allowed values of <c>registrations</c>, <c>groups</c>, 
	/// <c>check-ins</c>, or <c>services</c> (case insensitive).
	/// </exception>
	public static implicit operator ConnectedProduct(string value) => new(ValidateAndCleanString(value));

	/// <summary>
	/// Equivalent to calling <see cref="ToString"/> on the <see cref="ConnectedProduct"/> instance.
	/// </summary>
	/// <param name="value">The <see cref="ConnectedProduct"/> instance to convert.</param>
	public static implicit operator string(ConnectedProduct value) => value.ToString();

	private ConnectedProduct(string value) => _value = value;

	private static string ValidateAndCleanString(string value)
	{
		string cleanValue = value.Trim().ToLowerInvariant();

		string[] allowedValues = ["registrations", "groups", "check-ins", "services"];
		if (!allowedValues.Contains(cleanValue))
		{
			throw new InvalidCastException(
				"Value must be 'registrations', 'groups', 'check-ins', or 'services' (case insensitive).");
		}

		return cleanValue;
	}
}
