using Assignment5.BUL.Model;
using Assignment5.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.BUL
{
  public  class AuthorManagerService:IAuthorManagerService
    {
       public IAuthorRepository repository;
       public AuthorManagerService(IAuthorRepository repository)
        {
            this.repository = repository;
        }
        public IEnumerable<Model.AuthorModel> GetListAuthor()
        {
            var authors = repository.GetAllAuthor();
            var listauthors = (from a in authors
                                  select new AuthorModel
                                  {
                                      AuthorID =a.AuthorID,
                                      AuthorName =a.AuthorName

                                  });
            return listauthors;
        }
    }
}
