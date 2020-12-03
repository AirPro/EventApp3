using EventApp3.Models.DataLayer;
using EventApp3.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace EventApp3.Controllers
{
	public class EventController : Controller
	{
		private Repository<EventApp3.Models.DomainModels.Event> events { get; set; }

		public EventController(FreidrdFinalProjectContext ctx) => events = new Repository<Models.DomainModels.Event>(ctx);
		
		

		

		//[HttpGet]
		//public ViewResult Edit(int id)
		//{
		//	this.LoadViewBag("Edit");
		//	var e = this.GetClass(id);
		//	return View("Add" e);
		//}

		//public IActionResult Index()
		//{
		//	return View();
		//}
	}
}
