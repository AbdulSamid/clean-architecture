using Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		public Task<T> AddAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public Task<IReadOnlyList<T>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<T> GetAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(T entity)
		{
			throw new NotImplementedException();
		}
	}
}
