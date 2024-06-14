using DapperMySQL.Api.Modules.WeatherModule;

namespace DapperMySQL.Api;

public static class WebApplicationExtensions
{
    public static void MapModuleRoutes(this WebApplication app)
    {
        app.MapWeatherRoutes();
    }

}
