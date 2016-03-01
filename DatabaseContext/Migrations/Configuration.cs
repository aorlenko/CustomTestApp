namespace DatabaseContext.Migrations
{
    using DomainModel;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext.OrdersContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OrdersContext context)
        {
            var defaultStandards = new List<Order>();

            defaultStandards.Add(new Order("ABCDE", DateTime.Now));
            defaultStandards.Add(new Order("EFGHI", DateTime.Now));

            foreach (var order in defaultStandards)
                context.Orders.AddOrUpdate(order);
        }
    }
}
