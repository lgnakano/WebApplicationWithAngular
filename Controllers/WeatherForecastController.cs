using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.DataAccess;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public ApplicationDbContext dbContext;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] Locations = new[]
        {
            "Tampa","New York City", "Rio De Janiero", "Tokyo","London", "Kingston"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            dbContext = context;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            WeatherForecast wf = dbContext.WeatherForcasts
                                .First();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = wf.Date,
                TemperatureC = wf.TemperatureC,
                Summary = wf.Summary,
                Location = wf.Location
            })
            .ToArray();
        }
    }
}
