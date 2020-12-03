using EventApp3.Models.DomainModels;
using System;

namespace EventApp3.Models.DataLayer
{
	public class EventUnitOfWork : IEventUnitOfWork
	{
		private FreidrdFinalProjectContext context { get; set; }
		public EventUnitOfWork(FreidrdFinalProjectContext ctx) => context = ctx;

        private Repository<Event> eventData;
        public Repository<Event> Events
        {
            get
            {
                if (eventData == null)
                    eventData = new Repository<Event>(context);
                return eventData;
            }
        }

		public void Save() => context.SaveChanges();
    }

}
