using EventApp3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace EventApp3.Controllers
{
	public class EventController : Controller
	{
		private FreidrdFinalProjectContext context { get; set; }
		public EventController(FreidrdFinalProjectContext ctx)
		{
			context = ctx;
		}

		[HttpGet]
		public IActionResult Add()
		{
			ViewBag.Action = "Add";
			ViewBag.Events = context.Events.OrderBy(e => e.EventId).ToList();
			return View("Edit", new Event());
		}

		//[HttpGet]
		//public IActionResult Edit(int id)
		//{
		//	ViewBag.Action = "Edit";
		//	ViewBag.Events = context.Events.OrderBy(e => e.EventId).ToList();
		//	var event = context.Events.Find(id);
        //  return View(event);
		//}

		//public IActionResult Index()
		//{
		//	return View();
		//}
	}
}
