using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TheyWorkForYou.IntegrationTests;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton(_ => new ConfigurationBuilder()
            .AddUserSecrets(typeof(Startup).Assembly)
            .Build());

        services.AddSingleton(provider =>
        {
            var configurationRoot = provider.GetRequiredService<IConfigurationRoot>();

            var section = configurationRoot.GetSection(typeof(Client).Namespace);
            return section.Get<Settings>();
        });

        services.AddSingleton<Client>();
    }
}