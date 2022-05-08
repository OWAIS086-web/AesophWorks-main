using System;
using System.Collections.Generic;
using System.Linq;
using AesophWorks.Entities;
using System.Web;
using System.Web.Mvc;
using AesophWorks.ViewModels;
using AesophWorks.Services;

namespace AesophWorks.Controllers
{
    public class HandleController : Controller
    {
        // GET: Handle
        public ActionResult Index(string SearchTerm)
        {
            HandleListingViewModel model = new HandleListingViewModel();
            var HandleLsit = ItemDataServices.Instance.GetAllHandles(SearchTerm);
            List<MyList> myList = new List<MyList>();

            foreach (var item in HandleLsit)
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
            HandleActionViewModel model = new HandleActionViewModel();
            model.Items = ItemServices.Instance.GetAllItems("");
            if (ID != 0)
            {
                var Handle = ItemDataServices.Instance.GetHandle(ID);
                model.ID = Handle.ID;
                model.Name = Handle.Name;
                model.ItemID = Handle.ItemID;
                model.Price = Handle.Price;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(HandleActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var Handle = ItemDataServices.Instance.GetHandle(model.ID);

                Handle.ID = model.ID;
                Handle.Name = model.Name;
                Handle.ItemID = model.ItemID;
                Handle.Price = model.Price;
                ItemDataServices.Instance.UpdateHandle(Handle);

            }
            else
            {
                var Handle = new Handle();
                Handle.ID = model.ID;
                Handle.Name = model.Name;
                Handle.ItemID = model.ItemID;
                Handle.Price = model.Price;
                ItemDataServices.Instance.SaveHandle(Handle);
            }
            return RedirectToAction("Index", "Handle");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            HandleActionViewModel model = new HandleActionViewModel();
            var Handle = ItemDataServices.Instance.GetHandle(ID);
            model.ID = Handle.ID;
            model.Name = Handle.Name;

            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(HandleActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var Handle = ItemDataServices.Instance.GetHandle(model.ID);
                ItemDataServices.Instance.DeleteHandle(Handle.ID);

            }
            return RedirectToAction("Index", "Handle");

        }
    }
}