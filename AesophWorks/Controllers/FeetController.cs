using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AesophWorks.Entities;
using System.Web.Mvc;
using AesophWorks.ViewModels;
using AesophWorks.Services;

namespace AesophWorks.Controllers
{
    public class FeetController : Controller
    {
        // GET: Feet
        public ActionResult Index(string SearchTerm)
        {
            FeetListingViewModel model = new FeetListingViewModel();
            var FeetLsit = ItemDataServices.Instance.GetAllFeets(SearchTerm);
            List<MyList> myList = new List<MyList>();

            foreach (var item in FeetLsit)
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
            FeetActionViewModel model = new FeetActionViewModel();
            model.Items = ItemServices.Instance.GetAllItems("");
            if (ID != 0)
            {
                var Feet = ItemDataServices.Instance.GetFeet(ID);
                model.ID = Feet.ID;
                model.Name = Feet.Name;
                model.ItemID = Feet.ItemID;
                model.Price = Feet.Price;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(FeetActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var Feet = ItemDataServices.Instance.GetFeet(model.ID);

                Feet.ID = model.ID;
                Feet.Name = model.Name;
                Feet.ItemID = model.ItemID;
                Feet.Price = model.Price;
                ItemDataServices.Instance.UpdateFeet(Feet);

            }
            else
            {
                var Feet = new Feet();
                Feet.ID = model.ID;
                Feet.Name = model.Name;
                Feet.ItemID = model.ItemID;
                Feet.Price = model.Price;
                ItemDataServices.Instance.SaveFeet(Feet);
            }
            return RedirectToAction("Index", "Feet");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            FeetActionViewModel model = new FeetActionViewModel();
            var Feet = ItemDataServices.Instance.GetFeet(ID);
            model.ID = Feet.ID;
            model.Name = Feet.Name;

            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(FeetActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var Feet = ItemDataServices.Instance.GetFeet(model.ID);
                ItemDataServices.Instance.DeleteFeet(Feet.ID);

            }
            return RedirectToAction("Index", "Feet");

        }
    }
}