using AesophWorks.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AesophWorks.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]

        public ActionResult LogOut()
        {
            Session["ID"] = null;
            Session["UserName"] = null;
            Session["Email"] = null;
            Session["Role"] = null;
            return View("Login");
        }



        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = UserServices.Instance.GetUserForLogin(username, password);
            if (user != null)
            {
               
                Session["ID"] = user.ID.ToString();
                Session["UserName"] = user.UserName.ToString();
                Session["Email"] = user.Email.ToString();
                Session["Role"] = user.Role.ToString();
                if (user.Role == "Admin")
                {
                    return RedirectToAction("Dashboard", "Admin");
                }
                else if (user.Role == "User")
                {
                    return RedirectToAction("Dashboard", "User");
                }
                else
                {
                    string msg = "Invalid Password or UserName";
                    TempData["ErrorMessage"] = msg;
                    Session["ID"] = null;
                    Session["UserName"] = null;
                    Session["Email"] = null;
                    Session["Role"] = null;

                }

            }
            return RedirectToAction("Login", "Home");
        }
    }
}