using Collektions.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Collektions.Core.Entities;
using System.Threading.Tasks;

namespace Collektions.Infrastructure
{
    public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity, IAggregateRoot
    {
        public Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> FirstAsync(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public Task<T> FirstOrDefaultAsync(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
