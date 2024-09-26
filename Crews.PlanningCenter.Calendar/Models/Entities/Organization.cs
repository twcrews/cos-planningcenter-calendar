using Crews.PlanningCenter.Calendar.Models.Entities.Values;

namespace Crews.PlanningCenter.Calendar.Models.Entities;

/// <summary>
/// An administrative structure, usually representing a single church. Contains date/time formatting and time zone 
/// preferences.
/// </summary>
public class Organization
{
	/// <summary>
	/// Unique identifier for the organization.
	/// </summary>
	public required string ID { get; set; }

	/// <summary>
	/// The name of the organization.
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// The time zone of the organization.
	/// </summary>
	public string? TimeZone { get; set; }

	/// <summary>
	/// <list type="bullet">
	/// 	<item><c>true</c> indicates hours for times will use a 24-hour clock.</item>
	///   <item><c>false</c> indicates hours for times will use a 12-hour clock.</item>
	/// </list>
	/// </summary>
	public bool? TwentyFourHourTime { get; set; }

	/// <summary>
	/// Possible values:
	/// <list type="bullet"> 
	/// 	<item><c>%d/%m/%Y</c>: indicates date/month/year formatting.</item>
	/// 	<item><c>%m/%d/%Y</c>: indicates month/date/year formatting.</item>	
	/// </list>
	/// </summary>
	public DateFormat? DateFormat { get; set; }

	/// <summary>
	/// Only available when requested with the <c>?fields</c> param
	/// </summary>
	public bool? Onboarding { get; set; }
}
