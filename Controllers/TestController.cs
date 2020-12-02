﻿using EventApp3.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventApp3.Controllers
{
	public class TestController : Controller
	{
		private Repository<EventApp3.Models.DomainModels.Event> events { get; set; }

		public TestController(FreidrdFinalProjectContext ctx) => events = new Repository<Models.DomainModels.Event>(ctx);

		public ViewResult Index()
		{
			var options = new QueryOptions<EventApp3.Models.DomainModels.Event>
			{
				OrderBy = e => e.EventId
			};
			return View(events.List(options));
		}
		[HttpGet]
		public ViewResult Add() => View();

		[HttpPost]
		public IActionResult Add(EventApp3.Models.DomainModels.Event e)
		{
			if (ModelState.IsValid)
			{
				if (e.EventId == 0)
					events.Insert(e);
				else
					events.Update(e);
				events.Save();
				return RedirectToAction("Index", "Test");
			}
			else
			{
				string operation = (e.EventId == 0) ? "Add" : "Edit";
				//this.LoadViewBag(operation);
				return View();
			}

		}
		
	}
}
