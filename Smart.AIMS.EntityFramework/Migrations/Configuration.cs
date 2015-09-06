using System.Data.Entity.Migrations;

namespace Smart.AIMS.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AIMS.EntityFramework.AIMSDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AIMS";
        }

        protected override void Seed(AIMS.EntityFramework.AIMSDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
