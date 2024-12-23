
using SMAdvancedC_DotNet.Database.Models;
using Microsoft.EntityFrameworkCore;
using SMAdvancedC_DotNet.GenericRepository.Persistance.Repositories;

namespace SMDotNet.GenericRepositoryPattern.Dependencies
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            services.AddControllers().AddJsonOptions(opt =>
            {
                opt.JsonSerializerOptions.PropertyNamingPolicy = null;
            });

            services.AddScoped<IBlogRepository, BlogRepository>();

            return services;
        }
    }
}
