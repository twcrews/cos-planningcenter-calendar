namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents a gender value on a Planning Center Calendar resource.
/// </summary>
public readonly struct Gender
{
	private readonly char _value;

	/// <summary>
	/// Represents a male gender.
	/// </summary>
	public static Gender Male => new('M');

	/// <summary>
	/// Represents a female gender.
	/// </summary>
	public static Gender Female => new('F');

	/// <summary>
	/// Instantiates a <see cref="Gender"/> with the default value of <c>M</c> (Male).
	/// </summary>
	public Gender() => _value = 'M';

	/// <summary>
	/// Gets the string representation of the internal value of the <see cref="Gender"/>.
	/// </summary>
	/// <returns>
	/// Either <c>M</c>, or <c>F</c> for <see cref="Male"/>, or <see cref="Female"/>, respectively.
	/// </returns>
	public override string ToString() => _value.ToString();

	/// <summary>
	/// Attempts to parse the given <see cref="string"/> into its <see cref="Gender"/> representation.
	/// </summary>
	/// <param name="value">The <see cref="string"/> to parse.</param>
	/// <exception cref="InvalidCastException">
	/// <paramref name="value"/> was not one of the allowed values of <c>M</c> or <c>F</c> (case insensitive).
	/// </exception>
	public static implicit operator Gender(string value) => new(CleanAndValidateChar(char.Parse(value)));

	/// <summary>
	/// Attempts to parse the given <see cref="char"/> into its <see cref="Gender"/> representation.
	/// </summary>
	/// <param name="value">The <see cref="char"/> to parse.</param>
	/// <exception cref="InvalidCastException">
	/// <paramref name="value"/> was not one of the allowed values of <c>M</c> or <c>F</c> (case insensitive).
	/// </exception>
	public static implicit operator Gender(char value) => new(CleanAndValidateChar(value));

	/// <summary>
	/// Equivalent to calling <see cref="ToString"/> on the <see cref="Gender"/> instance.
	/// </summary>
	/// <param name="value">The <see cref="Gender"/> instance to convert.</param>
	public static implicit operator string(Gender value) => value.ToString();

	/// <summary>
	/// Equivalent to calling <see cref="ToString"/> on the <see cref="Gender"/> instance, but as type 
	/// <see cref="char"/>.
	/// </summary>
	/// <param name="value">The <see cref="Gender"/> instance to convert.</param>
	public static implicit operator char(Gender value) => value._value;

	private Gender(char value) => _value = value;

	private static char CleanAndValidateChar(char value)
	{
		char cleanValue = char.ToUpperInvariant(value);
		if (!"MF".Contains(cleanValue))
		{
			throw new InvalidCastException("Value must be 'M' or 'F' (case insensitive).");
		}

		return cleanValue;
	}
}
