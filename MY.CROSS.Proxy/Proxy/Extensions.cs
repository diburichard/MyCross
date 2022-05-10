using Microsoft.Extensions.DependencyInjection;

namespace MS.COTAS.Cross.Proxy.Proxy
{
    public static class Extensions
    {
        public static IServiceCollection AddProxyHttp(this IServiceCollection services)
        {
            services.AddSingleton<IHttpClient, CustomHttpClient>();
            return services;
        }
    }
}
