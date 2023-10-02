using Microsoft.Extensions.DependencyInjection;

namespace TheyWorkForYou.IntegrationTests;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<Client>();
    }
}