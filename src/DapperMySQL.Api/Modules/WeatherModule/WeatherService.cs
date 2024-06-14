namespace DapperMySQL.Api.Modules.WeatherModule;

public class WeatherService : IWeatherService
{
    public Task<IEnumerable<WeatherForecast>> GetForecasts()
    {
        var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

        return Task.FromResult<IEnumerable<WeatherForecast>>(Enumerable.Range(1, 5).Select(index =>
            new WeatherForecast
            (
                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Random.Shared.Next(-20, 55),
                summaries[Random.Shared.Next(summaries.Length)]
            ))
            .ToArray());
    }
}

public interface IWeatherService
{
    public Task<IEnumerable<WeatherForecast>> GetForecasts();
}