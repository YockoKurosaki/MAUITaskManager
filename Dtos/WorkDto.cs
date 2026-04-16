namespace Dtos;

public class WorkDto
{
	public int Id { get; set; }
	public int ProjectId { get; set; }
	public string? Name { get; set; }
	public string? Description { get; set; }
	public DateTime CreatedDate { get; set; }
	public DateTime? UpdatedDate { get; set; }
	public DateTime? StartDate { get; set; }
	public DateTime? EndDate { get; set; }
	public StatusEnum Status { get; set; }
}
