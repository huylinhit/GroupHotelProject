using MyLibrary.DAOs;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void AddUser(User user) => UserDAO.Instance.AddUser(user);

        public void DeleteUser(int id) => UserDAO.Instance.RemoveUserByID(id);

        public User? ValidateLogin(string email, string pwd) => UserDAO.Instance.ValidateLogin(email, pwd);

        public User? GetUserByID(int id) => UserDAO.Instance.GetUserByID(id);

        public IEnumerable<User> GetUsers() => UserDAO.Instance.GetUsers();

        public void UpdateUser(User user) => UserDAO.Instance.UpdateUser(user);

        public IEnumerable<User> GetInActiveManager() => UserDAO.Instance.GetInActiveManager();
    }
}
