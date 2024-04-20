using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _producersService;
        public ProducersController(IProducersService producersService)
        {
            _producersService = producersService;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _producersService.GetAllAsync();
            return View(allProducers);
        }
    }
}
