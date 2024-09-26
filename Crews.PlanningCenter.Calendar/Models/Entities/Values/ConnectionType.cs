namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents a Connection Type value on a Planning Center Calendar resource.
/// </summary>
public readonly struct ConnectionType
{
	private readonly string _value;

	/// <summary>
	/// Represents a Signup connection type.
	/// </summary>
	public static ConnectionType Signup => new("signup");

	/// <summary>
	/// Represents a Group connection type.
	/// </summary>
	public static ConnectionType Group => new("group");

	/// <summary>
	/// Represents an Event connection type.
	/// </summary>
	public static ConnectionType Event => new("event");

	/// <summary>
	/// Represents a ServiceType connection type.
	/// </summary>
	public static ConnectionType ServiceType => new("service_type");

	/// <summary>
	/// Instantiates an <see cref="ConnectionType"/> with the default value of <c>signup</c>.
	/// </summary>
	public ConnectionType() => _value = "signup";

	/// <summary>
	/// Gets the string representation of the internal value of the <see cref="ConnectionType"/>.
	/// </summary>
	/// <returns>
	/// Either <c>signup</c>, <c>group</c>, <c>event</c>, or <c>service_type</c>.
	/// </returns>
	public override string ToString() => _value;

	/// <summary>
	/// Attempts to parse the given <see cref="string"/> into its <see cref="ConnectionType"/> representation.
	/// </summary>
	/// <param name="value">The <see cref="string"/> to parse.</param>
	/// <exception cref="InvalidCastException">
	/// <paramref name="value"/> was not one of the allowed values of <c>signup</c>, <c>group</c>, <c>event</c>, or 
	/// <c>service_type</c> (case insensitive).
	/// </exception>
	public static implicit operator ConnectionType(string value) => new(ValidateAndCleanString(value));

	/// <summary>
	/// Equivalent to calling <see cref="ToString"/> on the <see cref="ConnectionType"/> instance.
	/// </summary>
	/// <param name="value">The <see cref="ConnectionType"/> instance to convert.</param>
	public static implicit operator string(ConnectionType value) => value.ToString();

	private ConnectionType(string value) => _value = value;

	private static string ValidateAndCleanString(string value)
	{
		string cleanValue = value.Trim().ToLowerInvariant();

		string[] allowedValues = ["signup", "group", "event", "service_type"];
		if (!allowedValues.Contains(cleanValue))
		{
			throw new InvalidCastException("Value must be 'signup', 'group', 'event', or 'service_type' (case insensitive).");
		}

		return cleanValue;
	}
}
