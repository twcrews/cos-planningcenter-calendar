using Crews.PlanningCenter.Calendar.Models.Entities.Values;

namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// A question to answer when requesting to book a room or resource.
/// </summary>
public class ResourceQuestion
{
	/// <summary>
	/// Related <see cref="Resource"/> resource.
	/// </summary>
	public string? ResourceID { get; set; }

	/// <summary>
	/// Unique identifier for the question.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// UTC time at which the question was created.
	/// </summary>
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// Possible values:
	/// <list type="bullet">
  ///   <item><c>dropdown</c>: predefined list of choices as an answer.</item>
  ///   <item><c>paragraph</c>: expected answer is a paragraph.</item>
  ///   <item><c>text</c>: expected answer is a sentence.</item>
  ///   <item><c>yesno</c>: expected answer is 'Yes' or 'No'.</item>
  ///   <item><c>section_header</c>: used to separate questions in the UI, no expected answer.</item>
	/// </list>
	/// </summary>
	public QuestionKind? Kind { get; set; }

	/// <summary>
	/// UTC time at which the question was updated.
	/// </summary>
	public DateTime? UpdatedAt { get; set; }

	/// <summary>
	/// If <see cref="Kind"/> is <c>dropdown</c>, represents a string of dropdown choices separated by the <c>|</c> 
	/// character.
	/// </summary>
	public string? Choices { get; set; }

	/// <summary>
	/// Optional description of the question.
	/// </summary>
	public string? Description { get; set; }

	/// <summary>
	/// If <see cref="Kind"/> is <c>dropdown</c>, <c>true</c> indicates that more than one selection is permitted.
	/// </summary>
	public bool? MultipleSelect { get; set; }

	/// <summary>
	/// <list type="bullet">
  ///   <item><c>true</c> indicates answering the question is not required when booking</item>
  ///   <item><c>false</c> indicates answering the question is required when booking</item>
	/// </list>
	/// </summary>
	public bool? Optional { get; set; }

	/// <summary>
	/// Position of question in list in the UI.
	/// </summary>
	public int? Position { get; set; }

	/// <summary>
	/// The question to be answered.
	/// </summary>
	public string? Question { get; set; }
}
