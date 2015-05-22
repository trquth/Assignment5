using Assignment5.BUL.Model;
using Assignment5.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.BUL
{
    public class CategoryManagerService : ICategoryManagerService
    {
        public ICategoryRepository repository;
        public CategoryManagerService(ICategoryRepository repository)
        {
            this.repository = repository;
        }
        public IEnumerable<Model.CategoryModel> GetListCategory()
        {
            var categories = repository.GetAllCategory();
            int i = categories.Count();
            var listcategories = (from a in categories
                                  select new CategoryModel
                                 {
                                     Category_ID = a.Category_ID,
                                     Category_Name = a.Category_Name

                                 });
            return listcategories;
        }
    }
}
