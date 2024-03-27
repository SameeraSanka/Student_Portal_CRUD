using Microsoft.AspNetCore.Mvc;

namespace StudentPortalWeb.Controllers
{
    public class StudentsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add()
        {

        }
    }
}
