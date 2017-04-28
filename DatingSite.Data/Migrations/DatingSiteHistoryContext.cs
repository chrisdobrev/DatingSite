using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;

namespace DatingSite.Data.Migrations
{
    class DatingSiteHistoryContext : HistoryContext
    {
        public DatingSiteHistoryContext(DbConnection connection, string defaultSchema)
            : base(connection, defaultSchema)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HistoryRow>().Property(h => h.MigrationId).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<HistoryRow>().Property(h => h.ContextKey).HasMaxLength(256).IsRequired();
        }
    }
}
