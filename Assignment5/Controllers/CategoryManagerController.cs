using Assignment5.BUL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Assignment5.Models;

namespace Assignment5.Controllers
{
    public class CategoryManagerController : Controller
    {
        
        private ICategoryManagerService category;
        public CategoryManagerController(ICategoryManagerService category)
        {
            this.category = category;
        }

        public ActionResult Index(int? page)
        {
            var model = GetUsers();
            var numberPage = page ?? 1;
            var onPageOfCategory = model.ToPagedList(numberPage, 5);
            ViewBag.OnePageOfUser = onPageOfCategory;
            return View();
        }
        public IEnumerable<CategoryViewModel> GetUsers()
        {
            var model = category.GetListCategory();
            var  = from a in model
                        select new CategoryViewModel
                        {
                           Category_ID =a.Category_ID,
                           Category_Name =a.Category_Name
                        };
            return users;
        }

    }
}
