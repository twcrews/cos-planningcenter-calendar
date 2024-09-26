namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// A template for generating a report.
/// </summary>
public class ReportTemplate
{
	/// <summary>
	/// Unique identifier for the report.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// The contents of the report template.
	/// </summary>
	public string? Body { get; set; }

	/// <summary>
	/// UTC time at which the report was created.
	/// </summary>
	/// <remarks>
	/// <b>NOTE</b>: In the Planning Center API documentation, <see cref="CreatedAt"/> is <see 
	/// 	href="https://developer.planning.center/docs/#/apps/calendar/2022-07-07/vertices/report_template%23attributes">
	/// 	incorrectly</see> 
	/// given the <see cref="string"/> type.
	/// <br/><br/>
	/// The actual type returned by the API is <see cref="DateTime"/>.
	/// </remarks>
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// A summarization of the report.
	/// </summary>
	public string? Description { get; set; }

	/// <summary>
	/// The title of the report.
	/// </summary>
	public string? Title { get; set; }

	/// <summary>
	/// UTC time at which the report was updated.
	/// </summary>
	/// <remarks>
	/// <b>NOTE</b>: In the Planning Center API documentation, <see cref="UpdatedAt"/> is <see 
	/// 	href="https://developer.planning.center/docs/#/apps/calendar/2022-07-07/vertices/report_template%23attributes">
	/// 	incorrectly</see> 
	/// given the <see cref="string"/> type.
	/// <br/><br/>
	/// The actual type returned by the API is <see cref="DateTime"/>.
	/// </remarks>
	public DateTime? UpdatedAt { get; set; }
}
