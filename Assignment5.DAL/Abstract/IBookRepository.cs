using Assignment5.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.DAL.Abstract
{
    public interface IBookRepository
    {
        IQueryable<Book> Book { get; }
        IQueryable<Book> GetAllBook();
        Book GetBookById(int id);
        int Create(Book book);
        int Update(Book book);
        int Delete(Book book);
        void Save();
    }
}
