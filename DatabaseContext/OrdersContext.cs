using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseContext
{
    public class OrdersContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public OrdersContext():base("name=DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using modelBuilder here
            modelBuilder.Configurations.Add(new OrderEntityConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
