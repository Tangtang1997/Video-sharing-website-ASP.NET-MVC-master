using System.Data.Entity.Migrations;
using ASP_Video_Website.Models;

namespace ASP_Video_Website.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

          /*  context.Categories.AddOrUpdate(
                new Category() { CategoryId = 1, Name = "Music"},
                new Category() { CategoryId = 2, Name = "Movie" },
                new Category() { CategoryId = 3, Name = "Entertainment" },
                new Category() { CategoryId = 4, Name = "News" },
                new Category() { CategoryId = 5, Name = "Sport" }
                );*/
        }
    }
}
