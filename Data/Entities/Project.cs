
using SQLite;
namespace Data.Entities;

public class Project
{
	[PrimaryKey, AutoIncrement]
	public int Id { get; set; }
	public string? Name { get; set; }
}
