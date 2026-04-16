namespace Repositories.Interfaces;

public interface IRepository<T> where T : new()
{
	Task<List<T>> GetAll();
	Task<T> GetById(int id);
	Task<int> Add(T entity); //SQLite returns the count of affected rows
	Task<int> Update(T entity); //SQLite returns the count of affected rows
	Task<int> Delete(int id); //SQLite returns the count of affected rows
}
