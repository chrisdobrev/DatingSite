using DatingSite.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DatingSite.Data
{
    public class DatingSiteContext : IdentityDbContext<ApplicationUser>
    {
        public DatingSiteContext()
            : base("DatingSiteContext", throwIfV1Schema: false)
        {
        }

        public static DatingSiteContext Create()
        {
            return new DatingSiteContext();
        }
    }
}
