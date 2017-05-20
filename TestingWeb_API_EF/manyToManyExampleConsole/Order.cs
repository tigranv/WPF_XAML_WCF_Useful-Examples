using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manyToManyExampleConsole
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public int Quantity { get; set; }
        public ICollection<Product> Product { get; set; }
        public Order()
        {
            Product = new List<Product>();
        }
    }
}
