using Assignment5.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.DAL.Abstract
{
    public interface ICategoryRepository
    {
        IQueryable<Category> Category { get; }
        IQueryable<Category> GetAllCategory();
        Category GetCategoryById(int id);
        int Create(Category category);
        int Update(Category category);
        int Delete(Category category);
        void Save();
    }
}
