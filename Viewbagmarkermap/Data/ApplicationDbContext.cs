using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Viewbagmarkermap.Models;

namespace Viewbagmarkermap.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Location> Locations { get; set; }




       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Location>(
                    lo =>
                    {
                        lo.HasNoKey();
                        lo.ToView("View_Locations");
                       
                    });
        }*/





    }
}
