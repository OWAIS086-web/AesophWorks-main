using AesophWorks.Entities;
using AesophWorks.Services;
using AesophWorks.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AesophWorks.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Dashboard()
        {
            
            return View();
        }
       
        public ActionResult Users(string SearchTerm)
        {
            UsersListingViewModel model = new UsersListingViewModel();
            model.Users = UserServices.Instance.GetAllUsers(SearchTerm);
            return View(model);
        }

        [HttpGet]
        public ActionResult UserAction(int ID = 0)
        {
            UsersActionViewModel model = new UsersActionViewModel();
            if (ID != 0)
            {
                var user = UserServices.Instance.GetUser(ID);
                model.ID = user.ID;
                model.Name = user.Name;
                model.UserName = user.UserName;
                model.Email = user.Email;
                model.Password = user.Password;
                model.Role = user.Role;
                model.Contact = user.Contact;
                ViewData["Role"] = user.Role;
                return View("UserAction", model);

            }
            else
            {
                return View("UserAction", model);
            }
        }

     

        [HttpPost]
        public ActionResult UserAction(UsersActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var user = UserServices.Instance.GetUser(model.ID);

                user.ID = model.ID;
                user.Contact = model.Contact;
                user.Name = model.Name;
                user.Email = model.Email;
                user.Password = model.Password;
                user.Role = model.Role;
                user.UserName = model.UserName;
                UserServices.Instance.UpdateUser(user);

            }
            else
            {
                var user = new User();
                user.Contact = model.Contact;
                user.Email = model.Email;
                user.Name = model.Name;
                user.Password = model.Password;
                user.Role = model.Role;
                user.UserName = model.UserName;
                UserServices.Instance.SaveUser(user);
            }
            return RedirectToAction("Users", "Admin");
        }


        [HttpGet]
        public ActionResult DeleteUser(int ID)
        {
            UsersActionViewModel model = new UsersActionViewModel();
            var user = UserServices.Instance.GetUser(ID);
            model.ID = user.ID;
            model.UserName = user.UserName;
            return View("_DeleteUser", model);
        }

        [HttpPost]
        public ActionResult DeleteUser(UsersActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var user = UserServices.Instance.GetUser(model.ID);
                UserServices.Instance.DeleteUser(user.ID);

            }
            return RedirectToAction("Users", "Admin");

        }
    }
}