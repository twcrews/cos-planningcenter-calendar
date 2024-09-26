namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents a question kind value on a Planning Center Calendar resource.
/// </summary>
public readonly struct QuestionKind
{
	private readonly string _value;

	/// <summary>
	/// Predefined list of choices as an answer.
	/// </summary>
	public static QuestionKind DropDown => new("dropdown");

	/// <summary>
	/// Expected answer is a paragraph.
	/// </summary>
	public static QuestionKind Paragraph => new("paragraph");

	/// <summary>
	/// Expected answer is a sentence.
	/// </summary>
	public static QuestionKind Text => new("text");

	/// <summary>
	/// Expected answer is 'Yes' or 'No'.
	/// </summary>
	public static QuestionKind YesOrNo => new("yesno");

	/// <summary>
	/// Used to separate questions in the UI, no expected answer.
	/// </summary>
	public static QuestionKind SectionHeader => new("section_header");

	/// <summary>
	/// Instantiates a <see cref="QuestionKind"/> with the default value of <c>dropdown</c>.
	/// </summary>
	public QuestionKind() => _value = "dropdown";

	/// <summary>
	/// Gets the string representation of the internal value of the <see cref="QuestionKind"/>.
	/// </summary>
	/// <returns>
	/// Either <c>dropdown</c>, <c>paragraph</c>, <c>text</c>, <c>yesno</c>, or <c>section_header</c>.
	/// </returns>
	public override string ToString() => _value;

	/// <summary>
	/// Attempts to parse the given <see cref="string"/> into its <see cref="QuestionKind"/> representation.
	/// </summary>
	/// <param name="value">The <see cref="string"/> to parse.</param>
	/// <exception cref="InvalidCastException">
	/// <paramref name="value"/> was not one of the allowed values of <c>dropdown</c>, <c>paragraph</c>, 
	/// <c>text</c>, <c>yesno</c>, or <c>section_header</c> (case insensitive).
	/// </exception>
	public static implicit operator QuestionKind(string value) => new(ValidateAndCleanString(value));

	/// <summary>
	/// Equivalent to calling <see cref="ToString"/> on the <see cref="QuestionKind"/> instance.
	/// </summary>
	/// <param name="value">The <see cref="QuestionKind"/> instance to convert.</param>
	public static implicit operator string(QuestionKind value) => value.ToString();

	private QuestionKind(string value) => _value = value;

	private static string ValidateAndCleanString(string value)
	{
		string cleanValue = value.Trim().ToLowerInvariant();

		string[] allowedValues = ["dropdown", "paragraph", "text", "yesno", "section_header"];
		if (!allowedValues.Contains(cleanValue))
		{
			throw new InvalidCastException(
				"Value must be 'dropdown', 'paragraph', 'text', 'yesno', or 'section_header' (case insensitive).");
		}

		return cleanValue;
	}
}
