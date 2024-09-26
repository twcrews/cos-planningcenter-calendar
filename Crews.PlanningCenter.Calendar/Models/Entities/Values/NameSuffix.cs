namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents a name prefix value on a Planning Center Calendar resource.
/// </summary>
public readonly struct NameSuffix
{
	private readonly string _value;

	/// <summary>
	/// Represents the name prefix 'Jr.'.
	/// </summary>
	public static NameSuffix Junior => new("Jr.");

	/// <summary>
	/// Represents the name prefix 'Sr.'.
	/// </summary>
	public static NameSuffix Senior => new("Sr.");

	/// <summary>
	/// Represents the name prefix 'Ph.D.'.
	/// </summary>
	public static NameSuffix PhD => new("Ph.D.");

	/// <summary>
	/// Represents the name prefix 'II'.
	/// </summary>
	public static NameSuffix II => new("II");

	/// <summary>
	/// Represents the name prefix 'III'.
	/// </summary>
	public static NameSuffix III => new("III");

	/// <summary>
	/// Instantiates an <see cref="NameSuffix"/> with the default value of <c>Jr.</c>.
	/// </summary>
	public NameSuffix() => _value = "Jr.";

	/// <summary>
	/// Gets the string representation of the internal value of the <see cref="NameSuffix"/>.
	/// </summary>
	/// <returns>
	/// Either <c>Jr.</c>, <c>Sr.</c>, <c>Ph.D.</c>, <c>II</c>, or <c>III</c>.
	/// </returns>
	public override string ToString() => _value;

	/// <summary>
	/// Attempts to parse the given <see cref="string"/> into its <see cref="NameSuffix"/> representation.
	/// </summary>
	/// <param name="value">The <see cref="string"/> to parse.</param>
	/// <exception cref="InvalidCastException">
	/// <paramref name="value"/> was not one of the allowed values of <c>Jr.</c>, <c>Sr.</c>, 
	/// <c>Ph.D.</c>, <c>II</c>, or <c>III</c> (case insensitive).
	/// </exception>
	public static implicit operator NameSuffix(string value) => new(ValidateAndCleanString(value));

	/// <summary>
	/// Equivalent to calling <see cref="ToString"/> on the <see cref="NameSuffix"/> instance.
	/// </summary>
	/// <param name="value">The <see cref="NameSuffix"/> instance to convert.</param>
	public static implicit operator string(NameSuffix value) => value.ToString();

	private NameSuffix(string value) => _value = value;

	private static string ValidateAndCleanString(string value)
	{
		string cleanValue = value.Trim().ToLowerInvariant();

		string[] allowedValues = ["Jr.", "Sr.", "Ph.D.", "II", "III"];
		if (!allowedValues.Contains(cleanValue))
		{
			throw new InvalidCastException(
				"Value must be 'Jr.', 'Sr.', 'Ph.D.', 'II', or 'III' (case insensitive).");
		}

		return cleanValue;
	}
}
