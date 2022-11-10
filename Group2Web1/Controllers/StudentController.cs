using Group2Web1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Group2Web1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {

            List<Studenti> studentet = new List<Studenti>();

            var studenti1 = new Studenti("Kastriot", "Gjoka", 20);
            var studenti2 = new Studenti("Munker", "Tac", 23);
            var studenti3 = new Studenti("Bleron", "Osmani", 19);

            studentet.Add(studenti1);
            studentet.Add(studenti2);
            studentet.Add(studenti3);

            return View(studentet);
        }

        public IActionResult ParaqitTopStudentin()
        {
            Studenti stud1 = new Studenti("Kastriot", "Gjoka", 20);
            
            return View(stud1);
        }
    }
}
