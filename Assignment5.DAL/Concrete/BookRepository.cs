using Assignment5.DAL.Abstract;
using Assignment5.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.DAL.Concrete
{
    public class BookRepository:DBContext, IBookRepository
    {
        public BookRepository(BookMNGTContext context ):base(context)
        {

        }
        public IQueryable<Models.Book> Book
        {
            get { return DbContext.Books.OrderBy(x => x.Title); }
        }

        public IQueryable<Models.Book> GetAllBook()
        {
            var model = DbContext.Books;
            return model;
        }

        public Models.Book GetBookById (int id)
        {
            var model = DbContext.Books.Find(id);
            return model;
        }

        public int Create(Models.Book book)
        {
            DbContext.Books.Add(book);
            return 1;
        }

        public int Update(Models.Book book)
        {
            DbContext.Entry(book).State = System.Data.Entity.EntityState.Modified;
            return 1;
        }

        public int Delete(Models.Book book)
        {
            DbContext.Entry(book).State = System.Data.Entity.EntityState.Deleted;
            return 1;
        }


        public void Save()
        {
            DbContext.SaveChanges();
        }
    }
}
