using DatingSite.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using MySql.Data.Entity;

namespace DatingSite.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    //[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class DatingSiteContext : IdentityDbContext<ApplicationUser>
    {
        public DatingSiteContext()
            : base("DatingSiteContext", throwIfV1Schema: false)
        {
            Database.SetInitializer(new DatingSiteInitializer());
        }

        public static DatingSiteContext Create()
        {
            return new DatingSiteContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>().Property(u => u.Id).HasMaxLength(256);
            modelBuilder.Entity<ApplicationUser>().Property(u => u.PasswordHash).HasMaxLength(256);
            modelBuilder.Entity<ApplicationUser>().Property(u => u.UserName).HasMaxLength(256);
            modelBuilder.Entity<ApplicationUser>().Property(u => u.Email).HasMaxLength(256);
        }
    }
}
