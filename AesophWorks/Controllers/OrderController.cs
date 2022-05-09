using AesophWorks.Services;
using AesophWorks.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AesophWorks.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index(string SearchTerm)
        {
            if (Session["Role"].ToString() == "User")
            {
                SearchTerm = Session["Name"].ToString();
            }
            OrderListingViewModel model = new OrderListingViewModel();
            model.Orders = UserServices.Instance.GetAllOrders(SearchTerm);
            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            OrderActionViewModel model = new OrderActionViewModel();
            var Order = UserServices.Instance.GetOrder(ID);
            model.ID = Order.ID;
            model.Item = Order.Item;

            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(OrderActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var Order = UserServices.Instance.GetOrder(model.ID);
                UserServices.Instance.DeleteOrder(Order.ID);

            }
            return RedirectToAction("Index", "Order");

        }


    }
}