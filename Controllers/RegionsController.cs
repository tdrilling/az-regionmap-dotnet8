using Microsoft.AspNetCore.Mvc;
using AzureRegionMapApp.Models;

namespace AzureRegionMapApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRegions()
        {
            var regions = new List<AzureRegion>
            {
                new AzureRegion { Name = "West Europe", Location = "Netherlands", Geography = "Europe", RegionCode = "westeurope", HasAvailabilityZones = true, Latitude = 52.3702, Longitude = 4.8952 },
                new AzureRegion { Name = "East US", Location = "Virginia", Geography = "Americas", RegionCode = "eastus", HasAvailabilityZones = true, Latitude = 37.4316, Longitude = -78.6569 },
                new AzureRegion { Name = "Southeast Asia", Location = "Singapore", Geography = "Asia Pacific", RegionCode = "southeastasia", HasAvailabilityZones = true, Latitude = 1.3521, Longitude = 103.8198 }
            };
            return Ok(regions);
        }
    }
}
