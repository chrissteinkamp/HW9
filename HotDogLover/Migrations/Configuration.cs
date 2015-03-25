namespace HotDogLover.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HotDogLover.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<HotDogLover.Models.Hotdog.HotDogLoverContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "HotDogLover.Models.Hotdog+HotDogLoverContext";
        }

        protected override void Seed(HotDogLover.Models.Hotdog.HotDogLoverContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Hotdogs.AddOrUpdate(i => i.ID,
                new Hotdog
                {
                    ID = 1,
                    Type = "When Harry Met Sally",
                    Date = DateTime.Parse("1989-1-11"),
                },

                 new Hotdog
                 {
                     ID = 2,
                     Type = "When Harry Met Sally",
                     Date = DateTime.Parse("1989-1-11"),
                 },

                 new Hotdog
                 {
                     ID = 3,
                     Type = "When Harry Met Sally",
                     Date = DateTime.Parse("1989-1-11"),
                 }
           );
        }
    }
}
