using Microsoft.AspNetCore.Mvc;

namespace Group2Web1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
