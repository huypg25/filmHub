using filmHub.data;
using Microsoft.AspNetCore.Mvc;

namespace filmHub.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
