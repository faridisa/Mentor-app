using Mentor_App.Data;
using Mentor_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mentor_App.Controllers
{
    public class HomeController(AbDbContext apDbContext) : Controller
    {
        public IActionResult Index()
        {
            var slider = apDbContext.Sliders.FirstOrDefault();
            return View(slider);
        }
    }
}
