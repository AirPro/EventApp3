using EventApp3.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventApp3.Models.DataLayer
{
	public interface IEventUnitOfWork
	{
		public Repository<Event> Events { get; }

		public void Save();
	}
}
