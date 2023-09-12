using Estate_Api.Repositories.BottomGridRepositories;
using Microsoft.AspNetCore.Mvc;

namespace Estate_Api.Controllers
{
    public class BottomGridsController : Controller
    {
        private readonly IBottomGridRepository _bottomGridRepository;

        public BottomGridsController(IBottomGridRepository bottomGridRepository)
        {
            _bottomGridRepository = bottomGridRepository;
        }
        [HttpGet]
        public async Task<IActionResult> BottomGridList()
        {
            var values = await _bottomGridRepository.GetAllBottomGridAsync();
            return Ok(values);
        }
    }
}
