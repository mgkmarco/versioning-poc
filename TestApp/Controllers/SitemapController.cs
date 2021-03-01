using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TestApp.Controllers
{
    public class SitemapController : Controller
    {
        [HttpGet("/segment/{segmentId}/language/{languageId}/section/{section}")]
        public IEnumerable<WeatherForecast> Get(
            [FromRoute] string segmentId,
            [FromRoute] string languageId,
            [FromRoute] Section section,
            [FromQuery] List<int> ids,
            [FromQuery] DateTime eventStartFrom,
            [FromQuery] DateTime eventStartTo,
            string include = "Competition")
        {
            return new List<WeatherForecast>();
        }
    }

    public enum Section
    {
        Sport = 0,
        Region = 1,
        Competition = 2,
        Event = 3
    }
}