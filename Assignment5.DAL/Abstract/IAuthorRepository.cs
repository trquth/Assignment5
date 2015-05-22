using Assignment5.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.DAL.Abstract
{
   public interface IAuthorRepository
    {
       IQueryable<Author> GetAllAuthor();
    }
}
