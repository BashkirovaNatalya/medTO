using medTO_MVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace medTO_MVC.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
