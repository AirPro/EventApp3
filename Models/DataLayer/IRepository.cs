using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventApp3.Models.DataLayer
{
	public interface IRepository<T> where T : EventApp3.Models.DomainModels.Event
	{
		IEnumerable<T> List(QueryOptions<T> options);
		T get(int id);
		void Insert(T entity);
		void Update(T entity);
		void Delete(T entity);
		void Save();
	}
}
