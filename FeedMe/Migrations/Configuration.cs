namespace FeedMe.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using FeedMe.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<FeedMe.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "FeedMe.Models.ApplicationDbContext";
        }

        protected override void Seed(FeedMe.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            var locations = new List<Location>
                {
                    new Location{LocationID=1,Description = "Outside Neville Alexander" },
                    new Location{LocationID=2,Description = "In the Cissy Gool Mall"},
                    new Location{LocationID=3,Description = "In the Sports Centre"},

                };
            //students.ForEach(s => context.Students.AddOrUpdate(p =>p.LastName, s));
            locations.ForEach(s => context.Locations.AddOrUpdate(p => p.Description, s));
            context.SaveChanges();

            var outlets = new List<Outlet>
                    {
                    new Outlet{OutletID=3,Name= "Tea Junction", ContactPhone = 0837720521, ContactEmail = "teajunction@myuct.ac.za", LocationID = 1},
                    new Outlet{OutletID=4,Name="We Will Grill You", ContactPhone = 0635219954, ContactEmail = "wwgy@gmail.com", LocationID = 1},
                    new Outlet{OutletID=2,Name="Cannot re-Fresh", ContactPhone = 0723145692, ContactEmail = "cannotrefresh@hotmail.com", LocationID = 3},
                    };
            outlets.ForEach(s => context.Outlets.AddOrUpdate(p => p.ContactPhone, s));
            context.SaveChanges();

            var reviews = new List<Review>
                    {
                    new Review{ReviewID=1050,Rating=1,Comment="Expensive for what you get", ReviewDate = DateTime.Today, OutletID = 1},
                    new Review{ReviewID=4022,Rating= 1,Comment = "Pay peanuts for peanuts.",ReviewDate = DateTime.Today, OutletID = 2},
                    new Review{ReviewID=4041,Rating= 1,Comment = "Mmm so good.", ReviewDate = DateTime.Today, OutletID = 1},
                    };
            reviews.ForEach(s => context.Reviews.AddOrUpdate(p => p.Comment, s));
            context.SaveChanges();

        }
    }
}
