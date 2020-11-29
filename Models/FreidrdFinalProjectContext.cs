
using Microsoft.EntityFrameworkCore;

namespace EventApp3.Models
{
    public class FreidrdFinalProjectContext : DbContext
    {
        
        public FreidrdFinalProjectContext(DbContextOptions<FreidrdFinalProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Event> Events { get; set; }

       
    }
}
