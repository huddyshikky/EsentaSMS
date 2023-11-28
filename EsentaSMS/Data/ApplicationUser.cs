using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace EsentaSMS.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Category { get; set; } = "Teacher";

        //[ForeignKey(nameof(Tenant))]
        //public int TenantId { get; set; } = 1;
        //public Tenant Tenant { get; set; }
    }

}
