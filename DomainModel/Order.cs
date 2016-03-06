using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Order
    {
        protected Order() { }

        public Order(string code, DateTime date)
        {
            Code = code;
            Date = date;
        }

        public int Id { get; private set; }
        public string Code { get; private set; }
        public DateTime Date { get; private set; }
        public ICollection<OrderLine> OrderLines { get; set; }
        public DateTime? CloseDate { get; set; }
    }
}
