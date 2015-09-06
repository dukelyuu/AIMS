using System.Data.Entity.Migrations;
using Smart.AIMS.Migrations.SeedData;
using EntityFramework.DynamicFilters;

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
            context.DisableAllFilters();
            new InitialDataBuilder(context).Build();
        }
    }
}
