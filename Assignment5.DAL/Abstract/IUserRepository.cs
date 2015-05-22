using Assignment5.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.DAL.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> User { get; }
        IQueryable<User> GetAllUser();
        User GetUserById(int id);
        int Create(User user);
        int Update(User user);
        int Delete(User user);
        void Save();
    }
}
