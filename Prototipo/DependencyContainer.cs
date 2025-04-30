namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductoRepositorio,ProductoRepositorioMemoria>();
            services.AddScoped<IProductoServicio, ProductoServicio>();
            services.AddScoped<IProductoValidador,ProductoValidador>();
            return services;
        }
    }

}
