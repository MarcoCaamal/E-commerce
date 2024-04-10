using Domain.Entities;

namespace Repository.Interfaces.Repository
{
    public interface IGenericRepository<TEntity, TId>
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity?> GetById(TId id);
        Task<int> Update(TEntity entity);
        Task<int> Insert(TEntity entity);
        Task<int> SoftDelete(TId id);
        Task<int> HardDelete(TId id);
    }
}
