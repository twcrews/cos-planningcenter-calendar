using Crews.PlanningCenter.Calendar.Models.Entities;
using Crews.PlanningCenter.Api.Models.Resources;
using Crews.PlanningCenter.Api.Models.Resources.Querying;
using Crews.PlanningCenter.Calendar.Models.Resources.Querying;

namespace Crews.PlanningCenter.Calendar.Models.Resources;

/// <summary>
/// A fetchable <see cref="Attachment"/> resource.
/// </summary>
public class AttachmentResource : CalendarSingletonResource<Attachment, AttachmentResource>,
	INamedApiResource,
	IIncludable<AttachmentResource, AttachmentIncludable>
{
	/// <inheritdoc />
	public static string ApiName => "attachment";

	/// <summary>
	/// The associated <see cref="EventResource"/>.
	/// </summary>
	public EventResource Event => GetNamedAssociated<EventResource>();

	internal AttachmentResource(Uri uri, HttpClient client) : base(uri, client) { }

	/// <inheritdoc />
	public AttachmentResource Include(params AttachmentIncludable[] included) => base.Include(included);
}

/// <summary>
/// A fetchable collection of <see cref="Attachment"/> resources.
/// </summary>
public class AttachmentResourceCollection
	: CalendarPaginatedResource<Attachment, AttachmentResourceCollection, AttachmentResource>, 
	INamedApiResource,
	IIncludable<AttachmentResourceCollection, AttachmentIncludable>,
	IOrderable<AttachmentResourceCollection, AttachmentOrderable>,
	IQueryable<AttachmentResourceCollection, AttachmentQueryable>
{
	/// <inheritdoc />
	public static string ApiName => "attachments";

	internal AttachmentResourceCollection(Uri uri, HttpClient client) : base(uri, client) { }

	/// <inheritdoc />
	public AttachmentResourceCollection Include(params AttachmentIncludable[] included) => base.Include(included);

	/// <inheritdoc />
	public AttachmentResourceCollection OrderBy(AttachmentOrderable orderer, Order order = Order.Ascending) 
		=> base.OrderBy(orderer, order);

	/// <inheritdoc />
	public AttachmentResourceCollection Query(params KeyValuePair<AttachmentQueryable, string>[] queries) 
		=> base.Query(queries);
}
