using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class CatalogController : Controller
    {
        [HttpGet("/segment/{segmentId}/language/{languageId}")]
        public Task<CatalogResponseDto> GetCatalogAsync(
            [FromRoute] string segmentId,
            [FromRoute] string languageId,
            [FromQuery] CatalogQuery catalogQuery)
        {
            /*
             * Call ISA to get the full catalog (ex. /isa/v2/601/en/category)
             * IFF includeContent; Call CRS
             * Additional logic goes here...
             *  Construct/Map to response
             */
            
            return Task.FromResult(new CatalogResponseDto());
        }
    }

    public class CatalogQuery
    {
        public string EventIds { get; set; } // comma delimited. EventIds will need to be mapped to FixtureTags in ISA 
        public string CompetitionIds { get; set; } // comma delimited
        public string RegionIds { get; set; } // comma delimited
        public string SportIds { get; set; } // comma delimited
        public string Exclude { get; set; }
        public int? EventStartingIn { get; set; } = null;
        public bool IncludeContent { get; set; } = false;
    }
}