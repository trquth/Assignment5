using Assignment5.BUL.Model;
using Assignment5.DAL.Abstract;
using Assignment5.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.BUL
{
    public class BookManagerService : IBookManagerService
    {
        public IBookRepository repository;
        public BookManagerService(IBookRepository repository)
        {
            this.repository = repository;
        }
        /// <summary>
        /// Ham tao moi mot quyen sach
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int CreateBook(Model.BookModel book)
        {
            var model = new Book();
            model.BookID = book.BookID;
            model.Title = book.Title;
            model.Price = book.Price;
            model.Decription = book.Decription;
            model.DatePublish = book.DatePublish;
            model.AuthorID = book.AuthorID;
            model.Category_ID = book.Category_ID;
            model.Image = book.Image;
            repository.Create(model);
            repository.Save();
            return 1;
        }
        /// <summary>
        /// Ham lay ra danh sach cac quyen sach
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Model.BookModel> GetListbook()
        {
            var books = repository.GetAllBook();
            var listbooks = (from a in books
                             select new BookModel
                             {
                                 BookID = a.BookID,
                                 Title = a.Title,
                                 Price = a.Price,
                                 Decription = a.Decription,
                                 DatePublish = a.DatePublish,
                                 AuthorID = a.AuthorID,
                                 Category_ID = a.Category_ID,
                                 Image = a.Image,
                                 AuthorName = a.Author.AuthorName,
                                 CategoryName = a.Category.Category_Name
                             });

            return listbooks;
        }
        /// <summary>
        /// Ham lay mot quyen sach dua vao ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model.BookModel GetBookById(int id)
        {
            var book = repository.GetBookById(id);
            var model = new BookModel();
            model.BookID = book.BookID;
            model.Title = book.Title;
            model.Price = book.Price;
            model.Decription = book.Decription;
            model.DatePublish = book.DatePublish;
            model.AuthorID = book.AuthorID;
            model.Category_ID = book.Category_ID;
            model.Image = book.Image;
            return model;
        }
        /// <summary>
        /// Ham sua mot quyen sach
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int UpdateBook(Model.BookModel book)
        {
            var model = new Book();
            model.BookID = book.BookID;
            model.Title = book.Title;
            model.Price = book.Price;
            model.Decription = book.Decription;
            model.DatePublish = book.DatePublish;
            model.AuthorID = book.AuthorID;
            model.Category_ID = book.Category_ID;
            model.Image = book.Image;
            repository.Update(model);
            repository.Save();
            return 1;
        }
        /// <summary>
        /// Ham xoa mot quyen sach
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int DeleteBook(BookModel book)
        {
            var model = new Book();
            model.BookID = book.BookID;
            model.Title = book.Title;
            model.Price = book.Price;
            model.Decription = book.Decription;
            model.DatePublish = book.DatePublish;
            model.AuthorID = book.AuthorID;
            model.Category_ID = book.Category_ID;
            model.Image = book.Image;
            repository.Delete(model);
            repository.Save();
            return 1;
        }
    }
}
