using Microsoft.AspNetCore.Mvc;

namespace medTO_MVC.Controllers
{
    public class CategoryController : Controller
    {

       

        public IActionResult Index()
        {
            return View();
        }
    }
}
