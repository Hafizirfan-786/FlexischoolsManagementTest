using FlexischoolsManagement.Domain.Repositories;

namespace FlexischoolsManagement.Infrastructure.Persistance.Repositories
{
    internal sealed class UnitOfWork : IUnitOfWork
    {
        private readonly FlexischoolsManagementDbContext _dbContext;

        public UnitOfWork(FlexischoolsManagementDbContext dbContext) => _dbContext = dbContext;

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            _dbContext.SaveChangesAsync(cancellationToken);
    }
}
