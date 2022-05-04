using AesophWorks.Database;
using AesophWorks.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AesophWorks.Services
{
    public class UserServices
    {
        #region Singleton
        public static UserServices Instance
        {
            get
            {
                if (instance == null) instance = new UserServices();
                return instance;
            }
        }
        private static UserServices instance { get; set; }
        private UserServices()
        {
        }
        #endregion


        public User GetUser(int ID)
        {
            using (var context = new AWContext())
            {
                return context.Users.Find(ID);
            }
        }

        public bool CheckRoleForAdmin()
        {

            bool Authenticaed = false;
            if (HttpContext.Current.Session["UserName"] == null)
            {
                Authenticaed = false;
            }

            string[] roles = System.Web.Security.Roles.GetRolesForUser(Convert.ToString(HttpContext.Current.Session["UserName"]));
            if (roles.Length != 0)
            {
                if (roles[0] == "Admin")
                {
                    Authenticaed = true;
                }
                else
                {
                    Authenticaed = false;
                }
            }
            else
            {
                Authenticaed = false;
            }
            return Authenticaed;


           
        }

        public User GetUserForLogin(string UserName, string Password)
        {
            try
            {
                using (var context = new AWContext())
                {
                    return context.Users.FirstOrDefault(x => x.UserName == UserName && x.Password == Password);
                }
            }

            catch (Exception ex)
            {

                throw;
            }
        }

        public User GetUserName(string UserName)
        {
            using (var context = new AWContext())
            {
                return context.Users.FirstOrDefault(x => x.UserName == UserName);
            }
        }

        public int GetUserID(string UserName)
        {
            using (var context = new AWContext())
            {
                return context.Users.Where(x => x.UserName == UserName).Select(x => x.ID).FirstOrDefault();
            }
        }

        public List<User> GetAllUsers(string search = null)
        {
            using (var context = new AWContext())
            {
                if (!string.IsNullOrEmpty(search))
                {
                    return context.Users.Where(p => p.UserName != null && p.UserName.ToLower()
                        .Contains(search.ToLower()))
                        .OrderBy(x => x.UserName)
                        .ToList();
                }
                else
                {
                    return context.Users
                        .OrderBy(x => x.UserName)
                        .ToList();
                }
            }
        }

        public void SaveUser(User user)
        {
            using (var context = new AWContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void UpdateUser(User user)
        {
            using (var context = new AWContext())
            {
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteUser(int ID)
        {
            using (var context = new AWContext())
            {

                var User = context.Users.Find(ID);
                context.Users.Remove(User);
                context.SaveChanges();
            }
        }


    }
}
