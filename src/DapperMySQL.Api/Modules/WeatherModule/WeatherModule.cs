
namespace DapperMySQL.Api.Modules.WeatherModule;

using Microsoft.AspNetCore.Http.HttpResults;

public static class WeatherModule
{
    public static void AddWeatherModule(this IServiceCollection services)
    {
        services.AddScoped<IWeatherService, WeatherService>();
    }

    public static void MapWeatherRoutes(this WebApplication app)
    {
        app.MapGet("/weatherforecast", HandleAsync)
        .WithName("GetWeatherForecast")
        .WithOpenApi();
    }

    public static async Task<Results<Ok<IEnumerable<WeatherForecast>>, NotFound>> HandleAsync(IWeatherService weatherService)
    {
        var forecasts = await weatherService.GetForecasts();
        return TypedResults.Ok(forecasts);
    }
}
