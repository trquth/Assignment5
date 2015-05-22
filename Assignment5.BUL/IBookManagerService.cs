using Assignment5.BUL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.BUL
{
    public interface IBookManagerService
    {
        /// <summary>
        /// Luu thong tin cua quyen sach
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        int CreateBook(BookModel book);
        /// <summary>
        /// Tra ve danh sach nhung quuyen sach da duoc sap xep
        /// </summary>
        /// <returns></returns>
        IEnumerable<BookModel> GetListbook();
        /// <summary>
        /// Tra ve tra ve thong tin quyen sach dua vao ma quyen sach
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BookModel GetBookById(int id);
        /// <summary>
        /// Sua thong tin quyen sach
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        int UpdateBook(BookModel book);
        /// <summary>
        /// Ham xoa thong tin quyen sach
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteBook(BookModel book);
        

    }
}
