using BaseConfig.BaseRepository.DatabaseConfig.Common.Interfaces;
using BaseConfig.EntityObject.Entity;
using BaseConfig.MethodResult;
using Microsoft.EntityFrameworkCore;

namespace BaseConfig.BaseRepository
{
    public class BaseRepository<T> : IRepository<T> where T : Entity
    {
        protected readonly DbSet<T> _dbSet;
        public T Add(T newEntity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyGuidAsync(Guid guid, int? siteId = null)
        {
            throw new NotImplementedException();
        }

        public Task ExecuteTransactionAsync(Func<Task<VoidMethodResult>> action)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByGuidAsync(Guid guid)
        {
            throw new NotImplementedException();
        }

        public T Update(T updateEntity)
        {
            throw new NotImplementedException();
        }
    }
}
