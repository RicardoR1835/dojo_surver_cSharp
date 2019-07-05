using Microsoft.AspNetCore.Mvc;

namespace firstASP
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("create")]
        public IActionResult Create(string name, string email, string location, string language, string comments)
        {
            ViewBag.Name = name;
            ViewBag.Email = email;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comments;
            return View("Show");
        }

    }
}