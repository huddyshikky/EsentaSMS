using EsentaSMS.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EsentaSMS.Data
{
    public class EsentaSMSContext(DbContextOptions<EsentaSMSContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<RecipientGrp> RecipientGrps { get; set; }
        public DbSet<County> Counties{ get; set; }
    }
   
}
