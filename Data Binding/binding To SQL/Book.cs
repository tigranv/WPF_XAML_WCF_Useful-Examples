using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binding_To_SQL
{
    public class Book
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public Book() { }
        public Book(string title, string description, string author)
        {
            Title = title;
            Description = description;
            Author = author;
        }
    }
}
