using Assignment5.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.DAL.Concrete
{
    public class DBContext
    {
        private BookMNGTContext context;
        public DBContext(BookMNGTContext context)
        {
            this.context = context;
        }
        protected BookMNGTContext DbContext
        {
            get
            {
                return context;
            }
        }
    }
}
