using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class BookViewModel
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public string Decription { get; set; }
        public string Content { get; set; }
        public System.DateTime DatePublish { get; set; }
        public Nullable<int> AuthorID { get; set; }
        public Nullable<int> Category_ID { get; set; }
        public string Image { get; set; }
        public string Category_Name { get; set; }
        public string AuthorName { get; set; }
    }
}