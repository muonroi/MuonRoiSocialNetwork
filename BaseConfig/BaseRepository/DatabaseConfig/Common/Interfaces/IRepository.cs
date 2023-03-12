using BaseConfig.EntityObject.Entity;
using BaseConfig.MethodResult;

namespace BaseConfig.BaseRepository.DatabaseConfig.Common.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        Task<T> GetByGuidAsync(Guid guid);
        Task<bool> AnyGuidAsync(Guid guid, int? siteId = null);
        T Add(T newEntity);
        T Update(T updateEntity);
        Task ExecuteTransactionAsync(Func<Task<VoidMethodResult>> action);
    }
}
