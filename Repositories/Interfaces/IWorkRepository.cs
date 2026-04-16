using Data.Entities;

namespace Repositories.Interfaces;

public interface IWorkRepository : IRepository<Work>
{
	Task<List<Work>> GetByProjectId(int projectId);
}
