using Assignment5.DAL.Abstract;
using Assignment5.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.DAL.Concrete
{
    public class UserRepository:DBContext, IUserRepository
    {
        public UserRepository(BookMNGTContext context ):base(context)
        {

        }
        public IQueryable<Models.User> User
        {
            get { return DbContext.Users.OrderBy(x => x.UserName); }
        }

        public IQueryable<Models.User> GetAllUser()
        {
            var model = DbContext.Users;
            return model;
        }

        public Models.User GetUserById(int id)
        {
            var model = DbContext.Users.Find(id);
            return model;
        }

        public int Create(Models.User user)
        {
            DbContext.Users.Add(user);
            return 1;
        }

        public int Update(Models.User user)
        {
            DbContext.Entry(user).State = System.Data.Entity.EntityState.Modified;
            return 1;
        }

        public int Delete(Models.User user)
        {
            DbContext.Entry(user).State = System.Data.Entity.EntityState.Deleted;
            return 1;
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }
    }
}
