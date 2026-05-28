using JwtAuthDemo.Services;
using JwtAuthDemo.Services.Interfaces;

namespace JwtAuthDemo.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddJwtAuthDemoServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, TokenService>();
            return services;
        }
    }
}