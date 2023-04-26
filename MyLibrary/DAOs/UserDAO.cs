using Microsoft.Extensions.Configuration;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.DAOs
{
    public class UserDAO
    {
        private static UserDAO instance;
        private static object instanceLock = new object();

        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<User> GetUsers()
        {
            IEnumerable<User> list = new List<User>();
            try
            {
                using (var db = new HotelProjectContext())
                {
                    list = db.Users.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public User? GetUserByID(int id)
        {
            User? i = null;
            using (var db = new HotelProjectContext())
            {
                i = db.Users.SingleOrDefault(p => p.UserId == id);
            }
            return i;
        }

        public User? GetUserByEmail(string email)
        {
            User? i = null;
            using (var db = new HotelProjectContext())
            {
                i = db.Users.SingleOrDefault(p => p.Email == email);
            }
            return i;
        }

        public User? ValidateLogin(string email, string pwd)
        {
            (string adminEmail, string adminPwd) = GetDefaultAccount();
            if (email == adminEmail && pwd == adminPwd)
            {
                return new User
                {
                    UserId = 0,
                    FirstName = "admin",
                    LastName = "admin",
                    Email = adminEmail,
                    Password = "",
                    Address = "",
                    Phone = "",
                    Role = "admin",
                    Status = "active",
                };
            }
            var list = GetUsers();
            var acc = list.SingleOrDefault(acc => acc.Email == email && acc.Password == pwd && acc.Status == "active");
            return acc;
        }

        public void AddUser(User item)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    db.Users.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveUser(User item)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    var p = db.Users.SingleOrDefault(p => p.UserId == item.UserId);
                    db.Users.Remove(p);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveUserByID(int id)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    var p = db.Users.SingleOrDefault(p => p.UserId == id);
                    db.Users.Remove(p);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateUser(User item)
        {
            try
            {
                using (var db = new HotelProjectContext())
                {
                    db.Entry<User>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public (string? Email,string? Password) GetDefaultAccount()
        {
            IConfiguration config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", true, true)
                                    .Build();
            return (config["Admin:Email"], config["Admin:Password"]);
        }

        public IEnumerable<User> GetInActiveManager()
        {
            IEnumerable<User> users = null;
            try
            {
                var context = new HotelProjectContext();

                users = context.Users
                    .Where(item => item.Role.Equals("manager") && item.Status.Equals("inactive"))
                    .ToList();


            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return users;
        }
    }
}
