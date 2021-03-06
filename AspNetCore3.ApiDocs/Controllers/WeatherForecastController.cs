﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AspNetCore3.ApiDocs.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Filters;

namespace AspNetCore3.ApiDocs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gets forecast for the next 5 days
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(GetWeatherForecastResponse), (int) HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var rng = new Random();
            var forecast = Enumerable.Range(1, 5).Select(index => new GetWeatherForecastResponseItem
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToList();

            return Ok(new GetWeatherForecastResponse
            {
                Forecast = forecast
            });
        }
    }
}
