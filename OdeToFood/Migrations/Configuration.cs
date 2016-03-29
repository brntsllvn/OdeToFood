namespace OdeToFood.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OdeToFood.Models.OdeToFoodDb";
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
            context.Restaurants.AddOrUpdate( r => r.Name, 
                new Restaurant { Name = "Sabatino's", City = "Upland", Country = "USA" },
                new Restaurant { Name = "Pinebox", City = "Seattle", Country = "USA" },
                new Restaurant { Name = "Plum", City = "Seattle", Country = "USA",
                                 Reviews = new List<RestaurantReview> {
                                    new RestaurantReview { Rating = 5, Body = "Good eats!"},
                                    new RestaurantReview { Rating = 6, Body = "Could be better...", ReviewerName = "Brent" }}
                               });
        }
    }
}