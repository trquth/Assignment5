using Assignment5.BUL;
using Assignment5.BUL.Model;
using Assignment5.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using PagedList;

namespace Assignment5.Controllers
{
    public class BookManagerController : Controller
    {
        private ICategoryManagerService category;
        private IBookManagerService book;
        private IAuthorManagerService author;
        public BookManagerController(ICategoryManagerService category, IBookManagerService book, IAuthorManagerService author)
        {
            this.category = category;
            this.book = book;
            this.author = author;

        }
        [HttpGet]
        public ActionResult CreateNewBook()
        {
            ViewBag.Category = GetCategory();
            ViewBag.Author = GetAuthor();
            return View();
        }
        private IEnumerable<BookViewModel> GetCategory()
        {

            var model = category.GetListCategory();
            int i = model.Count();
            var categories = from a in model
                             select new BookViewModel
                             {
                                 Category_ID = a.Category_ID,
                                 Category_Name = a.Category_Name
                             };
            return categories;

        }
        private IEnumerable<BookViewModel> GetAuthor()
        {

            var model = author.GetListAuthor();
            var authors = from a in model
                          select new BookViewModel
                          {
                              AuthorID = a.AuthorID,
                              AuthorName = a.AuthorName
                          };
            return authors;
        }
        [HttpPost]
        public ActionResult CreateNewBook(BookViewModel model, HttpPostedFileBase file)
        {
            var bookitem = new BookModel();
            if (file != null && file.ContentLength > 0)
            {
                string extension = Path.GetExtension(file.FileName);
                var fileName = System.Guid.NewGuid().ToString("N") + extension;
                var path = HostingEnvironment.MapPath("~/Images/");
                file.SaveAs(Path.Combine(path, fileName));
                bookitem.Image = fileName;
            }
            bookitem.Title = model.Title;
            bookitem.Price = model.Price;
            bookitem.Decription = model.Decription;
            bookitem.Content = model.Content;
            bookitem.DatePublish = DateTime.Now;
            bookitem.AuthorID = model.AuthorID;
            bookitem.Category_ID = model.Category_ID;
            book.CreateBook(bookitem);
            return Redirect("/");
        }
        public ActionResult Index(int? page)
        {
            var model = GetBook();
            var numberPage = page ?? 1;
            var onPageOfBooks = model.ToPagedList(numberPage, 5);
            ViewBag.OnePageOfBooks = onPageOfBooks;
            return View();
        }
        public IEnumerable<BookViewModel> GetBook()
        {
            var model = book.GetListbook();
            var books = from a in model
                        select new BookViewModel
                        {
                            BookID = a.BookID,
                            Title = a.Title,
                            Price = a.Price,
                            Decription = a.Decription,
                            Image = a.Image,
                            AuthorName = a.AuthorName,
                            Category_Name = a.CategoryName
                        };
            return books;
        }
    }
}
