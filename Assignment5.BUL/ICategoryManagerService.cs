using Assignment5.BUL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.BUL
{
    public interface ICategoryManagerService
    {
        /// <summary>
        /// Tra ve danh sach nhung loai da duoc sap xep
        /// </summary>
        /// <returns></returns>
        IEnumerable<CategoryModel> GetListCategory();
    }
}
