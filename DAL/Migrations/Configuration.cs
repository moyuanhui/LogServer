namespace LogServer.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LogServer.DAL.EfUnitOfWork>
    {
        public Configuration()
        {
            //AutomaticMigrationsEnabled = false;
            //允许自动迁移
            AutomaticMigrationsEnabled = true;
            //自动迁移默认情况下不扔掉列在我们的数据库中的表。如果我们不希望这样的行为，
            //我们可以告诉迁移明确允许数据丢失的配置类的AutomaticMigrationDataLossAllowed属性设置为true。
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LogServer.DAL.EfUnitOfWork context)
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
        }
    }
}
