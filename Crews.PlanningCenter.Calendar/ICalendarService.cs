using Crews.PlanningCenter.Calendar.Models.Resources;

namespace Crews.PlanningCenter.Calendar;

public interface ICalendarService
{
	public AttachmentResourceCollection Attachments { get; }
}
