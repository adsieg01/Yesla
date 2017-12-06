namespace Yesla.Web.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Yesla.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<Yesla.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Yesla.Data.ApplicationDbContext context)
        {
            var customers = new List<Customer>
            {
                new Customer {FirstName = "Michael", LastName = "Keaton", TripBooked = false},
                new Customer {FirstName = "Jack", LastName = "Sparrow", TripBooked = false},
                new Customer {FirstName = "Katie", LastName = "Chang", TripBooked = false},
                new Customer {FirstName = "Lisa", LastName = "Basham", TripBooked = false},
                new Customer {FirstName = "Stan", LastName = "Shelling", TripBooked = false},
                new Customer {FirstName = "Mary", LastName = "Kites", TripBooked = false}
            };
            customers.ForEach(s => context.Customers.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();
        }
    }
}
