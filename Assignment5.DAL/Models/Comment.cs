using System;
using System.Collections.Generic;

namespace Assignment5.DAL.Models
{
    public partial class Comment
    {
        public int CommentID { get; set; }
        public string Comments { get; set; }
        public Nullable<int> BookID { get; set; }
        public Nullable<int> UserId { get; set; }
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
