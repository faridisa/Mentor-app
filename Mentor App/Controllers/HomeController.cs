using Mentor_App.Data;
using Mentor_App.Models;
using Mentor_App.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mentor_App.Controllers
{
    public class HomeController(AbDbContext apDbContext) : Controller
    {
        public IActionResult Index()
        {
            var slider = apDbContext.Sliders.FirstOrDefault();
            var whyChooseUs = apDbContext.WhyUses.ToList();
            HomeVm homeVm = new HomeVm
            {
                Slider = slider,
                WhyUses = whyChooseUs
            };
            return View(homeVm);
        }
    }
}
