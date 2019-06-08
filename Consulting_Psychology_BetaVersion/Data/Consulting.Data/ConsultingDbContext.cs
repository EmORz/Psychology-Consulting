using Microsoft.EntityFrameworkCore;

namespace Consulting.Data
{
    public class ConsultingDbContext : DbContext
    {
        //Todo add DBSets
        /*   public DbSet<>  { get; set; }
           
           public DbSet<>  { get; set; }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}