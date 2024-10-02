using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("persons-list")]
        public IActionResult LoadPersonsList()
        {
            PersonGridModel personGridModel = new PersonGridModel()
            {
                GridTitle = "Persons List",
                Persons = new List<Person>()
                {
                    new Person() {PersonName="Sawan",JobTitle="CS" },
                    new Person(){PersonName="Sameer",JobTitle="Software Engineer"}

                }
            };
            return ViewComponent("Grid", new {grid=personGridModel});
        }
    }
}
