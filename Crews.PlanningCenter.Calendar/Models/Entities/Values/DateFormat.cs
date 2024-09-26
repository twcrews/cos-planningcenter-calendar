namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents a date format value on a Planning Center Calendar resource.
/// </summary>
public readonly struct DateFormat
{
	private readonly string _value;

	/// <summary>
	/// Represents day/month/year format.
	/// </summary>
	public static DateFormat DayMonthYear => new("%d/%m/%Y");

	/// <summary>
	/// Represents day/month/year format.
	/// </summary>
	public static DateFormat MonthDayYear => new("%m/%d/%Y");

	/// <summary>
	/// Instantiates a <see cref="DateFormat"/> with the default value of <c>%d/%m/%Y</c>.
	/// </summary>
	public DateFormat() => _value = "%d/%m/%Y";

	/// <summary>
	/// Gets the string representation of the internal value of the <see cref="DateFormat"/>.
	/// </summary>
	/// <returns>
	/// Either <c>%d/%m/%Y</c> or <c>%m/%d/%Y</c>.
	/// </returns>
	public override string ToString() => _value;

	/// <summary>
	/// Attempts to parse the given <see cref="string"/> into its <see cref="DateFormat"/> representation.
	/// </summary>
	/// <param name="value">The <see cref="string"/> to parse.</param>
	/// <exception cref="InvalidCastException">
	/// <paramref name="value"/> was not one of the allowed values of <c>%d/%m/%Y</c> or <c>%m/%d/%Y</c> (case sensitive).
	/// </exception>
	public static implicit operator DateFormat(string value) => new(ValidateAndCleanString(value));

	/// <summary>
	/// Equivalent to calling <see cref="ToString"/> on the <see cref="DateFormat"/> instance.
	/// </summary>
	/// <param name="value">The <see cref="DateFormat"/> instance to convert.</param>
	public static implicit operator string(DateFormat value) => value.ToString();

	private DateFormat(string value) => _value = value;

	private static string ValidateAndCleanString(string value)
	{
		string cleanValue = value.Trim();

		string[] allowedValues = ["%d/%m/%Y", "%m/%d/%Y"];
		if (!allowedValues.Contains(cleanValue))
		{
			throw new InvalidCastException(
				"Value must be '%d/%m/%Y' or '%m/%d/%Y' (case sensitive).");
		}

		return cleanValue;
	}
}
