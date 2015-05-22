using System;
using System.Collections.Generic;

namespace Assignment5.DAL.Models
{
    public partial class Book
    {
        public Book()
        {
            this.Comments = new List<Comment>();
        }

        public int BookID { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public string Decription { get; set; }
        public string Content { get; set; }
        public System.DateTime DatePublish { get; set; }
        public Nullable<int> AuthorID { get; set; }
        public Nullable<int> Category_ID { get; set; }
        public string Image { get; set; }
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
