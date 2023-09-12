using Estate_Api.Repositories.PopularLocationRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Api.Controllers
{
    public class PopularLocationsController : Controller
    {
        private readonly IPopularLocationRepository _locationRepository;

        public PopularLocationsController(IPopularLocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }
        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var value = await _locationRepository.GetAllPopularLocationAsync();
            return Ok(value);
        }
    }
}
