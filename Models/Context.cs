using Microsoft.EntityFrameworkCore;

namespace adv_bus_final.Models
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
            {
            }
                public DbSet<Recipe> Recipes {get; set;} 
                public DbSet<Rating> Ratings {get; set;} 
            
    }
}