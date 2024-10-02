using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Basket
{
    public static class BasketModule
    {
        public static IServiceCollection AddBasket(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

        public static IApplicationBuilder UseBasket(this IApplicationBuilder app)
        {
            return app;
        }
    }
}
