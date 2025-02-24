using ChawlEvent.Model;
using ChawlEvent.Repositories;
using ChawlEvent.Repositories.Interfaces;
using ChawlEvent.Services.Interfaces;
using ChawlEventAPI.Services;

namespace ChawlEventAPI.Extensions
{
    public static class FeatureServiceExtensions
    {
        public static void AddServiceDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IChawlEventDetailService, ChawlEventDetailService>();
            services.AddSingleton<IContributionService, ContributionService>();
            services.AddSingleton<IContributorService, ContributorService>();
            services.AddSingleton<IExpenseAssetService, ExpenseAssetService>();
            services.AddSingleton<IExpenseService, ExpenseService>();
            services.AddSingleton<IUserService, UserService>();
        }

        public static void AddRepositoryDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IChawlEventDetailRepository, ChawlEventDetailRepository>();
            services.AddSingleton<IContributionRepository, ContributionRepository>();
            services.AddSingleton<IContributorRepository, ContributorRepository>();
            services.AddSingleton<IExpenseAssetRepository, ExpenseAssetRepository>();
            services.AddSingleton<IExpenseRepository, ExpenseRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
        }

        public static void AddConfigurationDependencies(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.Configure<MongoDatabaseSetting>(builder.Configuration.GetSection("MongoDatabaseSetting"));
        }
    }
}
