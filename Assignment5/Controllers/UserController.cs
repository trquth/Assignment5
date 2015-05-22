using Assignment5.BUL.Model;
using Assignment5.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Assignment5.Models;
using Assignment5.BUL;

namespace Assignment5.Controllers
{
    public class UserController : Controller
    {
        private IUserManagerService user;
        public UserController(IUserManagerService user)
        {
            this.user = user;
        }

        public ActionResult Index(int? page)
        {
            var model = GetUsers();
            var numberPage = page ?? 1;
            var onPageOfUser = model.ToPagedList(numberPage, 5);
            ViewBag.OnePageOfUser = onPageOfUser;
            return View();
        }
        public IEnumerable<UserViewModel> GetUsers()
        {
            var model = user.GetListUser();
            var users = from a in model
                        select new UserViewModel
                        {
                           UserId =a.UserId,
                           UserName =a.UserName,
                           PassWord =a.PassWord,
                           RoleName = a.RoleName,
                        };
            return users;
        }
    }
}
