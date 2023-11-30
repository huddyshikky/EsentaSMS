using EsentaSMS.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace EsentaSMS.Data
{
    public class EsentaSMSContext(DbContextOptions<EsentaSMSContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<RecipientGrp> RecipientGrps { get; set; }
        public DbSet<Recipient> Recipients { get; set; }
        public DbSet<County> Counties{ get; set; }
        public DbSet<Sms> Sms { get; set; }
        public DbSet<SmsApi> SmsApis { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //seded data
            builder.Entity<Organisation>().HasData(
                new Organisation()
                {
                    Id = 1,
                    Name = "Esenta Computer Lab",
                    Address = "P.o Box 1950 - 30200 Kitale",
                    Email = "infor@esentacomputerlab.co.ke",
                    Phone = "0725 319 665",
                    Logo = "esenta.jpg"

                },
                new Organisation()
                {
                    Id = 2,
                    Name = "Esenta Computer Lab",
                    Address = "P.o Box 1950 - 30200 Kitale",
                    Email = "infor@esentacomputerlab.co.ke",
                    Phone = "0725 319 665",
                    Logo = "esenta.jpg"

                }, new Organisation()
                {
                    Id = 3,
                    Name = "Esenta Computer Lab",
                    Address = "P.o Box 1950 - 30200 Kitale",
                    Email = "infor@esentacomputerlab.co.ke",
                    Phone = "0725 319 665",
                    Logo = "esenta.jpg"

                }
                );
        }
       

    }
   
}
