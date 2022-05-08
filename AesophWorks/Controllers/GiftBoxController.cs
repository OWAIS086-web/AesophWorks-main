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
    public class GiftBoxController : Controller
    {
        // GET: GiftBox
        public ActionResult Index(string SearchTerm)
        {
            GiftBoxListingViewModel model = new GiftBoxListingViewModel();
            var GiftBoxLsit = ItemDataServices.Instance.GetAllGiftBoxs(SearchTerm);
            List<MyList> myList = new List<MyList>();

            foreach (var item in GiftBoxLsit)
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
            GiftBoxActionViewModel model = new GiftBoxActionViewModel();
            model.Items = ItemServices.Instance.GetAllItems("");
            if (ID != 0)
            {
                var GiftBox = ItemDataServices.Instance.GetGiftBox(ID);
                model.ID = GiftBox.ID;
                model.Name = GiftBox.Name;
                model.ItemID = GiftBox.ItemID;
                model.Price = GiftBox.Price;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(GiftBoxActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var GiftBox = ItemDataServices.Instance.GetGiftBox(model.ID);

                GiftBox.ID = model.ID;
                GiftBox.Name = model.Name;
                GiftBox.ItemID = model.ItemID;
                GiftBox.Price = model.Price;
                ItemDataServices.Instance.UpdateGiftBox(GiftBox);

            }
            else
            {
                var GiftBox = new GiftBox();
                GiftBox.ID = model.ID;
                GiftBox.Name = model.Name;
                GiftBox.ItemID = model.ItemID;
                GiftBox.Price = model.Price;
                ItemDataServices.Instance.SaveGiftBox(GiftBox);
            }
            return RedirectToAction("Index", "GiftBox");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            GiftBoxActionViewModel model = new GiftBoxActionViewModel();
            var GiftBox = ItemDataServices.Instance.GetGiftBox(ID);
            model.ID = GiftBox.ID;
            model.Name = GiftBox.Name;

            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(GiftBoxActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var GiftBox = ItemDataServices.Instance.GetGiftBox(model.ID);
                ItemDataServices.Instance.DeleteGiftBox(GiftBox.ID);

            }
            return RedirectToAction("Index", "GiftBox");

        }
    }
}