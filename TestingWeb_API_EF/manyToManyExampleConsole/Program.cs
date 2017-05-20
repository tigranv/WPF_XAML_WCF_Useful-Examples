using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manyToManyExampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCodefirstExample db = new MyCodefirstExample();
            db.Orders.ToList();
        }
    }
}
