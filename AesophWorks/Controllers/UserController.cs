using AesophWorks.Services;
using AesophWorks.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AesophWorks.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Dashboard()
        {
            return View();
        }


        public ActionResult MakeOrder()
        {
            MakeOrderViewModel model = new MakeOrderViewModel();
            model.Items = ItemServices.Instance.GetAllItems("");
            return View(model);
        }


    }
}