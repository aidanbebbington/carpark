using Core.Services.Pricing;
using Core.Services.Pricing.Rates;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Ioc
{
    public static class CoreServiceConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<IRate, StandardRate>();
            services.AddTransient<IRate, EarlyBirdRate>();
            services.AddTransient<IRate, NightRate>();
            services.AddTransient<IRate, WeekendRate>();
            services.AddTransient<IPricingService, PricingService>();
        }
    }
}
