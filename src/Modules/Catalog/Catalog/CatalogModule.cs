using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog
{
    public static class CatalogModule
    {
        public static IServiceCollection AddCatalog(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

        public static IApplicationBuilder UseCatalog(this IApplicationBuilder app)
        {
            
            return app;
        }
    }

}
