using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using WitStyle.Common;
using WitStyle.Data;
using WitStyle.Services;

namespace WitStyle.Web
{
    public static class ServiceRegistrator
    {
        public static void RegisterApplicationServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IAppConfiguration, WitStyleAppConfiguration>();
            serviceCollection.AddTransient<IMenuService, MenuService>();
            serviceCollection.AddTransient<WitStyleDbContext, WitStyleDbContext>();
            serviceCollection.AddAutoMapper();
        }
    }

}
