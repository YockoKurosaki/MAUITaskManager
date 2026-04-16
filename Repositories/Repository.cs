using Repositories.Interfaces;
using SQLite;

namespace Repositories;

public class Repository<T>(SQLiteAsyncConnection database) : IRepository<T> where T : new()
{
	protected readonly SQLiteAsyncConnection _database = database;

	public async Task<int> Add(T entity)
	{
		return await _database.InsertAsync(entity);
	}

	public async Task<int> Update(T entity)
	{
		return await _database.UpdateAsync(entity);
	}

	public async Task<int> Delete(int id)
	{
		return await _database.DeleteAsync<T>(id);
	}

	public async Task<List<T>> GetAll()
	{
		return await _database.Table<T>().ToListAsync();
	}

	public async Task<T> GetById(int id)
	{
		return await _database.FindAsync<T>(id);
	}
}
