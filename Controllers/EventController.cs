using EventApp3.Models.DataLayer;
using EventApp3.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace EventApp3.Controllers
{
	public class EventController : Controller
	{
		private EventUnitOfWork events { get; set; }

		public EventController(FreidrdFinalProjectContext ctx) => events = new EventUnitOfWork(ctx);
		
	}
}
