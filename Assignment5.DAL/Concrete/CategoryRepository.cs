using Assignment5.DAL.Abstract;
using Assignment5.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.DAL.Concrete
{
    public class CategoryRepository:DBContext, ICategoryRepository
    {
         public CategoryRepository(BookMNGTContext context ):base(context)
        {

        }
        public IQueryable<Models.Category> Category
        {
            get { return DbContext.Categories.OrderBy(x=>x.Category_Name); }
        }

        public IQueryable<Models.Category> GetAllCategory()
        {
            var model = DbContext.Categories.OrderBy(x => x.Category_Name);
            return model;
        }

        public Models.Category GetCategoryById(int id)
        {
            var model = DbContext.Categories.Find(id);
            return model;
        }

        public int Create(Models.Category category)
        {
            DbContext.Categories.Add(category);
            return 1;
        }

        public int Update(Models.Category category)
        {
            DbContext.Entry(category).State = System.Data.Entity.EntityState.Modified;
            return 1;
        }

        public int Delete(Models.Category category)
        {
            DbContext.Entry(category).State = System.Data.Entity.EntityState.Deleted;
            return 1;
        }


        public void Save()
        {
            DbContext.SaveChanges();
        }
    }
}
