using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Conductus.Logging.ASPCoreAPI
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //private readonly ILogger<WeatherForecastController> _logger;
        private readonly ILogger _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        public WeatherForecastController(ILoggerFactory logFactory)
        {
            //_logger = logger;
            _logger = logFactory.CreateLogger<WeatherForecastController>();
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            // Logging added 
            _logger.LogInformation("Log message in the Get() method");

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
