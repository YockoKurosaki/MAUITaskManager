using Dtos;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Data.Entities;

public class Work
{
	[PrimaryKey, AutoIncrement]
	public int Id { get; set; }
	[ForeignKey(typeof(Project))]
	public int ProjecId { get; set; }
	public string? Name { get; set; }
	public string? Description { get; set; }
	public DateTime CreatedDate { get; set; }
	public DateTime? UpdatedDate { get; set; }
	public DateTime? StartDate { get; set; }
	public DateTime? EndDate { get; set; }
	public StatusEnum Status { get; set; }

	[ManyToOne]
	public Project? Project { get; set; }
}
