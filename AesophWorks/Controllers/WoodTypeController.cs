using AesophWorks.Entities;
using AesophWorks.Services;
using AesophWorks.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AesophWorks.Controllers
{
    public class WoodTypeController : Controller
    {
        // GET: WoodType
        public ActionResult Index(string SearchTerm)
        {
            WoodTypeListingViewModel model = new WoodTypeListingViewModel();
            var WoodTypeLsit = ItemDataServices.Instance.GetAllWoodTypes(SearchTerm);
            List<MyList> myList = new List<MyList>();

            foreach (var item in WoodTypeLsit)
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
            WoodTypeActionViewModel model = new WoodTypeActionViewModel();
            model.Items = ItemServices.Instance.GetAllItems("");
            if (ID != 0)
            {
                var WoodType = ItemDataServices.Instance.GetWoodType(ID);
                model.ID = WoodType.ID;
                model.Name = WoodType.Name;
                model.ItemID = WoodType.ItemID;
                model.Price = WoodType.Price;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(WoodTypeActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var WoodType = ItemDataServices.Instance.GetWoodType(model.ID);

                WoodType.ID = model.ID;
                WoodType.Name = model.Name;
                WoodType.ItemID = model.ItemID;
                WoodType.Price = model.Price;
                ItemDataServices.Instance.UpdateWoodType(WoodType);

            }
            else
            {
                var WoodType = new WoodType();
                WoodType.ID = model.ID;
                WoodType.Name = model.Name;
                WoodType.ItemID = model.ItemID;
                WoodType.Price = model.Price;
                ItemDataServices.Instance.SaveWoodType(WoodType);
            }
            return RedirectToAction("Index", "WoodType");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            WoodTypeActionViewModel model = new WoodTypeActionViewModel();
            var WoodType = ItemDataServices.Instance.GetWoodType(ID);
            model.ID = WoodType.ID;
            model.Name = WoodType.Name;

            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(WoodTypeActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var WoodType = ItemDataServices.Instance.GetWoodType(model.ID);
                ItemDataServices.Instance.DeleteWoodType(WoodType.ID);

            }
            return RedirectToAction("Index", "WoodType");

        }
    }
}