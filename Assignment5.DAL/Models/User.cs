using System;
using System.Collections.Generic;

namespace Assignment5.DAL.Models
{
    public partial class User
    {
        public User()
        {
            this.Comments = new List<Comment>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public Nullable<int> RoleID { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Role Role { get; set; }
    }
}
