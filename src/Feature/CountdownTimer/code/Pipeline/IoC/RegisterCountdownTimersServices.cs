using Marginals.Feature.CountdownTimer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Marginals.Feature.CountdownTimer.Pipeline.IoC
{
    public class RegisterCountdownTimersServices : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ICountdownTimerItemRepository, CountdownTimerItemRepository>();
        }
    }
}