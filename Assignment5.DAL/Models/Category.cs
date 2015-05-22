using System;
using System.Collections.Generic;

namespace Assignment5.DAL.Models
{
    public partial class Category
    {
        public Category()
        {
            this.Books = new List<Book>();
        }

        public int Category_ID { get; set; }
        public string Category_Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
