using Assignment5.BUL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.BUL
{
   public interface IAuthorManagerService
    {
        /// <summary>
        /// Tra ve danh sach tac gia da duoc sap xep
        /// </summary>
        /// <returns></returns>
        IEnumerable<AuthorModel> GetListAuthor();
    }
}
