using Group2Web1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Group2Web1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ParaqitTopStudentin()
        {
            Studenti stud1 = new Studenti("Kastriot", "Gjoka", 20);
            
            return View(stud1);
        }
    }
}
