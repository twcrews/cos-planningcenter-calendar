namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents a feed type value on a Planning Center Calendar resource.
/// </summary>
public readonly struct FeedType
{
	private readonly string _value;

	/// <summary>
	/// Represents a Registrations feed.
	/// </summary>
	public static FeedType Registrations => new("registrations");

	/// <summary>
	/// Represents a Groups feed.
	/// </summary>
	public static FeedType Groups => new("groups");

	/// <summary>
	/// Represents an iCal feed.
	/// </summary>
	public static FeedType ICal => new("ical");

	/// <summary>
	/// Represents a Form feed.
	/// </summary>
	public static FeedType Form => new("form");

	/// <summary>
	/// Instantiates a <see cref="FeedType"/> with the default value of <c>registrations</c>.
	/// </summary>
	public FeedType() => _value = "registrations";

	/// <summary>
	/// Gets the string representation of the internal value of the <see cref="FeedType"/>.
	/// </summary>
	/// <returns>
	/// Either <c>registrations</c>, <c>groups</c>, <c>ical</c>, or <c>form</c>.
	/// </returns>
	public override string ToString() => _value;

	/// <summary>
	/// Attempts to parse the given <see cref="string"/> into its <see cref="FeedType"/> representation.
	/// </summary>
	/// <param name="value">The <see cref="string"/> to parse.</param>
	/// <exception cref="InvalidCastException">
	/// <paramref name="value"/> was not one of the allowed values of <c>registrations</c>, <c>groups</c>, 
	/// <c>ical</c>, or <c>form</c> (case insensitive).
	/// </exception>
	public static implicit operator FeedType(string value) => new(ValidateAndCleanString(value));

	/// <summary>
	/// Equivalent to calling <see cref="ToString"/> on the <see cref="FeedType"/> instance.
	/// </summary>
	/// <param name="value">The <see cref="FeedType"/> instance to convert.</param>
	public static implicit operator string(FeedType value) => value.ToString();

	private FeedType(string value) => _value = value;

	private static string ValidateAndCleanString(string value)
	{
		string cleanValue = value.Trim().ToLowerInvariant();

		string[] allowedValues = ["registrations", "groups", "ical", "form"];
		if (!allowedValues.Contains(cleanValue))
		{
			throw new InvalidCastException(
				"Value must be 'registrations', 'groups', 'ical', or 'form' (case insensitive).");
		}

		return cleanValue;
	}
}
