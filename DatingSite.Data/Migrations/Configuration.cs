namespace DatingSite.Data.Migrations
{
    using System.Data.Entity;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DatingSite.Data.DatingSiteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

            CommandTimeout = 3600;

            DbConfiguration.SetConfiguration(new MySql.Data.Entity.MySqlEFConfiguration());
            SetSqlGenerator(MySql.Data.Entity.MySqlProviderInvariantName.ProviderName, new MySql.Data.Entity.MySqlMigrationSqlGenerator());
            SetHistoryContextFactory(MySql.Data.Entity.MySqlProviderInvariantName.ProviderName, (connection, schema) => new MySql.Data.Entity.MySqlHistoryContext(connection, schema));
        }

        protected override void Seed(DatingSite.Data.DatingSiteContext context)
        {
        }
    }
}
