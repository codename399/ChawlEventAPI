using ChawlEvent.Model;
using ChawlEvent.Repositories;
using ChawlEvent.Repositories.Interfaces;
using ChawlEvent.Services.Interfaces;
using ChawlEventAPI.Services;

namespace ChawlEventAPI.Extensions
{
    public static class FeatureServiceExtensions
    {
        public static void AddFeatureServices(this IServiceCollection services)
        {
            services.AddSingleton<IChawlEventRepository, ChawlEventRepository>();
            services.AddSingleton<IChawlEventService, ChawlEventService>();
        }

        public static void AddSectionConfiguration(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.Configure<MongoDatabaseSetting>(builder.Configuration.GetSection("MongoDatabaseSetting"));
        }
    }
}
