using Microsoft.EntityFrameworkCore;
using SMAdvancedC_DotNet.Database.Models;
using SMAdvancedC_DotNet.RepositoryPattern.Persistance.Repositories;

namespace SMAdvancedC_DotNet.RepositoryPattern.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services,WebApplicationBuilder builder)
        {
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });


            services.AddScoped<IBlogRepository, BlogRepository>();

            services.AddControllers()
                    .AddJsonOptions(opt =>
                    {
                        opt.JsonSerializerOptions.PropertyNamingPolicy = null;
                    });
            return services;
                    
            
        }
    }
}
