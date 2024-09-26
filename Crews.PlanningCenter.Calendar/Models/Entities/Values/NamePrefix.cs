namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents a name prefix value on a Planning Center Calendar resource.
/// </summary>
public readonly struct NamePrefix
{
	private readonly string _value;

	/// <summary>
	/// Represents the name prefix 'Mr.'.
	/// </summary>
	public static NamePrefix Mister => new("Mr.");

	/// <summary>
	/// Represents the name prefix 'Mrs.'.
	/// </summary>
	public static NamePrefix Missus => new("Mrs.");

	/// <summary>
	/// Represents the name prefix 'Ms.'.
	/// </summary>
	public static NamePrefix Ms => new("Ms.");

	/// <summary>
	/// Represents the name prefix 'Miss'.
	/// </summary>
	public static NamePrefix Miss => new("Miss");

	/// <summary>
	/// Represents the name prefix 'Dr.'.
	/// </summary>
	public static NamePrefix Doctor => new("Dr.");

	/// <summary>
	/// Represents the name prefix 'Rev.'.
	/// </summary>
	public static NamePrefix Reverend => new("Rev.");

	/// <summary>
	/// Instantiates an <see cref="NamePrefix"/> with the default value of <c>Mr.</c>.
	/// </summary>
	public NamePrefix() => _value = "Mr.";

	/// <summary>
	/// Gets the string representation of the internal value of the <see cref="NamePrefix"/>.
	/// </summary>
	/// <returns>
	/// Either <c>Mr.</c>, <c>Mrs.</c>, <c>Ms.</c>, <c>Miss</c>, <c>Dr.</c>, or <c>Rev.</c>.
	/// </returns>
	public override string ToString() => _value;

	/// <summary>
	/// Attempts to parse the given <see cref="string"/> into its <see cref="NamePrefix"/> representation.
	/// </summary>
	/// <param name="value">The <see cref="string"/> to parse.</param>
	/// <exception cref="InvalidCastException">
	/// <paramref name="value"/> was not one of the allowed values of <c>Mr.</c>, <c>Mrs.</c>, 
	/// <c>Ms.</c>, <c>Miss</c>, <c>Dr.</c>, or <c>Rev.</c> (case insensitive).
	/// </exception>
	public static implicit operator NamePrefix(string value) => new(ValidateAndCleanString(value));

	/// <summary>
	/// Equivalent to calling <see cref="ToString"/> on the <see cref="NamePrefix"/> instance.
	/// </summary>
	/// <param name="value">The <see cref="NamePrefix"/> instance to convert.</param>
	public static implicit operator string(NamePrefix value) => value.ToString();

	private NamePrefix(string value) => _value = value;

	private static string ValidateAndCleanString(string value)
	{
		string cleanValue = value.Trim().ToLowerInvariant();

		string[] allowedValues = ["Mr.", "Mrs.", "Ms.", "Miss", "Dr.", "Rev."];
		if (!allowedValues.Contains(cleanValue))
		{
			throw new InvalidCastException(
				"Value must be 'Mr.', 'Mrs.', 'Ms.', 'Miss', 'Dr.', or 'Rev.' (case insensitive).");
		}

		return cleanValue;
	}
}
