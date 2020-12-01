using EventApp3.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventApp3.Controllers
{
	public class TestController : Controller
	{
		private Repository<EventApp3.Models.DomainModels.Event> data { get; set; }

		public TestController(FreidrdFinalProjectContext ctx) => data = new Repository<Models.DomainModels.Event>(ctx);

		public ViewResult Index()
		{
			var events = data.List(new QueryOptions<Models.DomainModels.Event>
			{
			
			});
			return View(events);
		}
	}
}
