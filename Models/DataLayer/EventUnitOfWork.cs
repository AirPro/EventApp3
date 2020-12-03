using EventApp3.Models.DomainModels;
using System;

namespace EventApp3.Models.DataLayer
{
	public class EventUnitOfWork : IEventUnitOfWork
	{
		private FreidrdFinalProjectContext context { get; set; }
		public EventUnitOfWork(FreidrdFinalProjectContext ctx) => context = ctx;

        private Repository<Event> dayData;
        public Repository<Event> Days
        {
            get
            {
                if (dayData == null)
                    dayData = new Repository<Event>(context);
                return dayData;
            }
        }

		public Repository<Event> Events => throw new NotImplementedException();

		public void Save() => context.SaveChanges();
    }

}
