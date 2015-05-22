using System;
using System.Collections.Generic;

namespace Assignment5.DAL.Models
{
    public partial class Author
    {
        public Author()
        {
            this.Books = new List<Book>();
        }

        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
