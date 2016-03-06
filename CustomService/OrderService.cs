using DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace CustomService
{
    public class OrderService:Service.OrderService
    {
        public OrderService(IOrdersRepository orderRepo)
            :base(orderRepo)
        {
        }

        public override IEnumerable<Order> GetAllOrders()
        {
            var orders = base.GetAllOrders();
            foreach(var order in orders)
            {
                order.CloseDate = DateTime.MinValue;
            }
            return orders;
        }
    }
}
