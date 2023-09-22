using Estate_Api.Repositories.TestimonialRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Api.Controllers
{
    public class TestimonialsController : Controller
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialsController(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }
        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            var value = await _testimonialRepository.GetAllTestimonialAsync();
            return Ok(value);
        }
    }
}
