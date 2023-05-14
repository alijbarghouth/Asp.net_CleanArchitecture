using CleanArchitecture.Domain.Shared;

namespace CleanArchitecture.Application
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IApplicationDBContext _dbContext;

        public UnitOfWork(IApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellation = default)
        {
            return await _dbContext.SaveChangesAsync(cancellation);
        }
    }
}
