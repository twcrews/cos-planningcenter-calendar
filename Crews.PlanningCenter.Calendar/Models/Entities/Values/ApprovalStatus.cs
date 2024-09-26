namespace Crews.PlanningCenter.Calendar.Models.Entities.Values;

/// <summary>
/// Represents an Approval Status value on a Planning Center Calendar resource.
/// </summary>
public readonly struct ApprovalStatus
{
	private readonly char _value;

	/// <summary>
	/// Represents an approved state.
	/// </summary>
	public static ApprovalStatus Approved => new('A');

	/// <summary>
	/// Represents a pending state.
	/// </summary>
	public static ApprovalStatus Pending => new('P');

	/// <summary>
	/// Represents a rejected state.
	/// </summary>
	public static ApprovalStatus Rejected => new('R');

	/// <summary>
	/// Instantiates an <see cref="ApprovalStatus"/> with the default value of <c>A</c> (Approved).
	/// </summary>
	public ApprovalStatus() => _value = 'A';

	/// <summary>
	/// Gets the string representation of the internal value of the <see cref="ApprovalStatus"/>.
	/// </summary>
	/// <returns>
	/// Either <c>A</c>, <c>P</c>, or <c>R</c> for <see cref="Approved"/>, <see cref="Pending"/>, or 
	/// <see cref="Rejected"/>, respectively.
	/// </returns>
	public override string ToString() => _value.ToString();

	/// <summary>
	/// Attempts to parse the given <see cref="string"/> into its <see cref="ApprovalStatus"/> representation.
	/// </summary>
	/// <param name="value">The <see cref="string"/> to parse.</param>
	/// <exception cref="InvalidCastException">
	/// <paramref name="value"/> was not one of the allowed values of <c>A</c>, <c>P</c>, or <c>R</c> (case insensitive).
	/// </exception>
	public static implicit operator ApprovalStatus(string value) => new(CleanAndValidateChar(char.Parse(value)));

	/// <summary>
	/// Attempts to parse the given <see cref="char"/> into its <see cref="ApprovalStatus"/> representation.
	/// </summary>
	/// <param name="value">The <see cref="char"/> to parse.</param>
	/// <exception cref="InvalidCastException">
	/// <paramref name="value"/> was not one of the allowed values of <c>A</c>, <c>P</c>, or <c>R</c> (case insensitive).
	/// </exception>
	public static implicit operator ApprovalStatus(char value) => new(CleanAndValidateChar(value));

	/// <summary>
	/// Equivalent to calling <see cref="ToString"/> on the <see cref="ApprovalStatus"/> instance.
	/// </summary>
	/// <param name="value">The <see cref="ApprovalStatus"/> instance to convert.</param>
	public static implicit operator string(ApprovalStatus value) => value.ToString();

	/// <summary>
	/// Equivalent to calling <see cref="ToString"/> on the <see cref="ApprovalStatus"/> instance, but as type 
	/// <see cref="char"/>.
	/// </summary>
	/// <param name="value">The <see cref="ApprovalStatus"/> instance to convert.</param>
	public static implicit operator char(ApprovalStatus value) => value._value;

	private ApprovalStatus(char value) => _value = value;

	private static char CleanAndValidateChar(char value)
	{
		char cleanValue = char.ToUpperInvariant(value);
		if (!"APR".Contains(cleanValue))
		{
			throw new InvalidCastException("Value must be 'A', 'P', or 'R' (case insensitive).");
		}

		return cleanValue;
	}
}
