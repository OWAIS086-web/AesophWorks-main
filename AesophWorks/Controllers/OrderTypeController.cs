using AesophWorks.Services;
using AesophWorks.ViewModels;
using AesophWorks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AesophWorks.Controllers
{
    public class OrderTypeController : Controller
    {
        // GET: OrderType
        public ActionResult Index(string SearchTerm)
        {
            OrderTypeListingViewModel model = new OrderTypeListingViewModel();
            var OrderTypeLsit = ItemDataServices.Instance.GetAllOrderTypes(SearchTerm);
            List<MyList> myList = new List<MyList>();

            foreach (var item in OrderTypeLsit)
            {
                var Item = ItemServices.Instance.GetItem(item.ItemID);
                myList.Add(new MyList { ID = item.ID, ItemID = item.ItemID, Item = Item, Name = item.Name, Price = item.Price });
            }
            model.MyLists = myList;
            return View(model);
        }

        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            OrderTypeActionViewModel model = new OrderTypeActionViewModel();
            model.Items = ItemServices.Instance.GetAllItems("");
            if (ID != 0)
            {
                var OrderType = ItemDataServices.Instance.GetOrderType(ID);
                model.ID = OrderType.ID;
                model.Name = OrderType.Name;
                model.ItemID = OrderType.ItemID;
                model.Price = OrderType.Price;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(OrderTypeActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var OrderType = ItemDataServices.Instance.GetOrderType(model.ID);

                OrderType.ID = model.ID;
                OrderType.Name = model.Name;
                OrderType.ItemID = model.ItemID;
                OrderType.Price = model.Price;
                ItemDataServices.Instance.UpdateOrderType(OrderType);

            }
            else
            {
                var OrderType = new OrderType();
                OrderType.ID = model.ID;
                OrderType.Name = model.Name;
                OrderType.ItemID = model.ItemID;
                OrderType.Price = model.Price;
                ItemDataServices.Instance.SaveOrderType(OrderType);
            }
            return RedirectToAction("Index", "OrderType");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            OrderTypeActionViewModel model = new OrderTypeActionViewModel();
            var OrderType = ItemDataServices.Instance.GetOrderType(ID);
            model.ID = OrderType.ID;
            model.Name = OrderType.Name;

            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(OrderTypeActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var OrderType = ItemDataServices.Instance.GetOrderType(model.ID);
                ItemDataServices.Instance.DeleteOrderType(OrderType.ID);

            }
            return RedirectToAction("Index", "OrderType");

        }
    }
}