using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FlexischoolsManagement.Domain.Repositories;
using FlexischoolsManagement.Infrastructure.Persistance;
using FlexischoolsManagement.Infrastructure.Persistance.Repositories;

namespace FlexischoolsManagement.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services)
        {
            services.AddScoped<IGenericRepository, GenericRepository>();
            services.AddDbContextPool<FlexischoolsManagementDbContext>(builder =>
            {
                builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            });

            return services;
        }
    }
}
