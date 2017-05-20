namespace manyToManyExampleConsole
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyCodefirstExample : DbContext
    {
        
        public MyCodefirstExample()
            : base("name=MyCodefirstExample")
        {
        }


        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }

}