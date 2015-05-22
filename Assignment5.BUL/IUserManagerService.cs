using Assignment5.BUL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.BUL
{
    public interface IUserManagerService
    {
        /// <summary>
        /// Luu thong tin cua admin
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        int CreateUser(UserModel user);
        /// <summary>
        /// Tra ve danh sach nhung admin da duoc sap xep
        /// </summary>
        /// <returns></returns>
        IEnumerable<UserModel> GetListUser();
        /// <summary>
        /// Tra ve tra ve thong tin admin dua vao ma ma admin
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UserModel GetUserById(int id);
        /// <summary>
        /// Sua thong tin  admin
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        int UpdateUser(UserModel user);
        /// <summary>
        /// Ham xoa thong tin quyen sach
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteUser(UserModel user);
        
    }
}
