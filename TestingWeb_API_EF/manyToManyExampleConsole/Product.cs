using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manyToManyExampleConsole
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public ICollection<Order> Order { get; set; }
        public Product()
        {
            Order = new List<Order>();
        }
    }
}
