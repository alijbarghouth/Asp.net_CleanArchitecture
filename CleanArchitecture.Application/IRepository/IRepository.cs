namespace CleanArchitecture.Application.IRepository
{
    public interface IRepository<TEntity>
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> FindByIdAsync(int id);
        IQueryable<TEntity> GetQueryable();
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(int id);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
