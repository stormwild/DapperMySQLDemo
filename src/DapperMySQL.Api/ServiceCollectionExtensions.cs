using DapperMySQL.Api.Modules.WeatherModule;

namespace DapperMySQL.Api;

public static class ServiceCollectionExtensions
{
    public static void AddModules(this IServiceCollection services)
    {
        services.AddWeatherModule();
    }
}
