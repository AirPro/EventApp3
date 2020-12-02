using EventApp3.Models.DomainModels;
using System;
using System.Linq.Expressions;

namespace EventApp3.Models.DataLayer
{
	public class QueryOptions<T> where T : Event
	{
		public Expression<Func<T, Object>> OrderBy { get; set; }
	}
}