using DatingSite.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System;

namespace DatingSite.Data
{

    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>().Property(u => u.Id).HasMaxLength(256);
        }
    }
}
