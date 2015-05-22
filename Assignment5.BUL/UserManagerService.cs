using Assignment5.BUL.Model;
using Assignment5.DAL.Abstract;
using Assignment5.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.BUL
{
    public class UserManagerService : IUserManagerService
    {
        private IUserRepository repository;
        public UserManagerService(IUserRepository repository)
        {
            this.repository = repository;
        }
        public int CreateUser(Model.UserModel user)
        {
            var model = new User();
            model.UserId = user.UserId;
            model.UserName = user.UserName;
            model.PassWord = user.PassWord;
            model.RoleID = user.RoleID;
            repository.Create(model);
            repository.Save();
            return 1;
        }

        public IEnumerable<Model.UserModel> GetListUser()
        {
            var books = repository.GetAllUser();
            var listbooks = (from a in books
                             select new UserModel
                             {
                                 UserId = a.UserId,
                                 UserName = a.UserName,
                                 PassWord = a.PassWord,
                                 RoleID = a.RoleID,
                                 RoleName =a.Role.RoleName,
                             });

            return listbooks;
        }

        public Model.UserModel GetUserById(int id)
        {
            var user = repository.GetUserById(id);
            var model = new UserModel();
            model.UserId = user.UserId;
            model.UserName = user.UserName;
            model.PassWord = user.PassWord;
            model.RoleID = user.RoleID;
            return model;
        }

        public int UpdateUser(Model.UserModel user)
        {
            var model = new User();
            model.UserId = user.UserId;
            model.UserName = user.UserName;
            model.PassWord = user.PassWord;
            model.RoleID = user.RoleID;            
            repository.Update(model);
            repository.Save();
            return 1;
        }

        public int DeleteUser(Model.UserModel user)
        {
            var model = new User();
            model.UserId = user.UserId;
            model.UserName = user.UserName;
            model.PassWord = user.PassWord;
            model.RoleID = user.RoleID;
            repository.Delete(model);
            repository.Save();
            return 1;
        }
    }
}
