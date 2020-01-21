using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Filters;

namespace AspNetCore3.ApiDocs.Responses
{
    public class GetWeatherForecastResponse
    {
        public IList<GetWeatherForecastResponseItem> Forecast { get; set; }
    }

    public class GetWeatherForecastResponseItem
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    internal class GetWeatherForecastResponseExample : IExamplesProvider<GetWeatherForecastResponse>
    {
        public GetWeatherForecastResponse GetExamples()
        {
            return new GetWeatherForecastResponse
            {
                Forecast = new List<GetWeatherForecastResponseItem>
                {
                    new GetWeatherForecastResponseItem
                    {
                        Date = DateTime.Now.AddDays(1),
                        TemperatureC = 33,
                        Summary = "Warm"
                    },
                    new GetWeatherForecastResponseItem
                    {
                        Date = DateTime.Now.AddDays(2),
                        TemperatureC = 11,
                        Summary = "Chilly"
                    },
                }
            };
        }
    }
}
