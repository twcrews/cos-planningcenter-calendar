namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents the publish visibility value on a Planning Center Calendar resource.
/// </summary>
public readonly struct PublishVisibility
{
	private readonly string _value;

	/// <summary>
	/// Represents a hidden visibility state.
	/// </summary>
	public static PublishVisibility Hidden => new("hidden");

	/// <summary>
	/// Represents a published visibility state.
	/// </summary>
	public static PublishVisibility Published => new("published");

	/// <summary>
	/// Instantiates a <see cref="PublishVisibility"/> with the default value of <c>hidden</c>.
	/// </summary>
	public PublishVisibility() => _value = "hidden";

	/// <summary>
	/// Gets the string representation of the internal value of the <see cref="PublishVisibility"/>.
	/// </summary>
	/// <returns>
	/// Either <c>hidden</c> or <c>published</c>.
	/// </returns>
	public override string ToString() => _value;

	/// <summary>
	/// Attempts to parse the given <see cref="string"/> into its <see cref="PublishVisibility"/> representation.
	/// </summary>
	/// <param name="value">The <see cref="string"/> to parse.</param>
	/// <exception cref="InvalidCastException">
	/// <paramref name="value"/> was not one of the allowed values of <c>hidden</c> or <c>published</c> (case 
	/// insensitive).
	/// </exception>
	public static implicit operator PublishVisibility(string value) => new(ValidateAndCleanString(value));

	/// <summary>
	/// Equivalent to calling <see cref="ToString"/> on the <see cref="PublishVisibility"/> instance.
	/// </summary>
	/// <param name="value">The <see cref="PublishVisibility"/> instance to convert.</param>
	public static implicit operator string(PublishVisibility value) => value.ToString();

	private PublishVisibility(string value) => _value = value;

	private static string ValidateAndCleanString(string value)
	{
		string cleanValue = value.Trim().ToLowerInvariant();

		string[] allowedValues = ["hidden", "published"];
		if (!allowedValues.Contains(cleanValue))
		{
			throw new InvalidCastException(
				"Value must be 'hidden' or 'published' (case insensitive).");
		}

		return cleanValue;
	}
}
