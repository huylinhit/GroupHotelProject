using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUserByID(int id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        public User? ValidateLogin(string email, string pwd);

        public IEnumerable<User> GetInActiveManager();

    }

}
