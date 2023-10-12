using Domain.Entities;

namespace Repository.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity?> Get(int id);
        Task<int> Update(TEntity entity);
        Task<int> Insert(TEntity entity);
        Task<int> Delete(int id);
    }
}
