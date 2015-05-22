using Assignment5.DAL.Abstract;
using Assignment5.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.DAL.Concrete
{
   public class AuthorRepository:DBContext, IAuthorRepository
    {
        public AuthorRepository(BookMNGTContext context ):base(context)
        {

        }
        public IQueryable<Models.Author> GetAllAuthor()
        {
            var model = DbContext.Authors;
            return model;
        }
    }
}
