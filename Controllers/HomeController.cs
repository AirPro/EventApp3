
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EventApp3.Models;
using EventApp3.Models.DataLayer;

namespace EventApp3.Controllers
{
    public class HomeController : Controller
    {
        
        private FreidrdFinalProjectContext context { get; set; }

        public HomeController(FreidrdFinalProjectContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var events = context.Events
                .OrderBy(e => e.EventId)
                .ToList();
            return View(events);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}

