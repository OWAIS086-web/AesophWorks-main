using AesophWorks.Services;
using AesophWorks.Entities;
using AesophWorks.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AesophWorks.Controllers
{
    public class AccentController : Controller
    {
        // GET: Accent
        public ActionResult Index(string SearchTerm)
        {
            AccentListingViewModel model = new AccentListingViewModel();
            var AccentLsit = ItemDataServices.Instance.GetAllAccents(SearchTerm);
            List<MyList> myList = new List<MyList>();

            foreach (var item in AccentLsit)
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
            AccentActionViewModel model = new AccentActionViewModel();
            model.Items = ItemServices.Instance.GetAllItems("");
            if (ID != 0)
            {
                var Accent = ItemDataServices.Instance.GetAccent(ID);
                model.ID = Accent.ID;
                model.Name = Accent.Name;
                model.ItemID = Accent.ItemID;
                model.Price = Accent.Price;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(AccentActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var Accent = ItemDataServices.Instance.GetAccent(model.ID);

                Accent.ID = model.ID;
                Accent.Name = model.Name;
                Accent.ItemID = model.ItemID;
                Accent.Price = model.Price;
                ItemDataServices.Instance.UpdateAccent(Accent);

            }
            else
            {
                var Accent = new Accent();
                Accent.ID = model.ID;
                Accent.Name = model.Name;
                Accent.ItemID = model.ItemID;
                Accent.Price = model.Price;
                ItemDataServices.Instance.SaveAccent(Accent);
            }
            return RedirectToAction("Index", "Accent");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            AccentActionViewModel model = new AccentActionViewModel();
            var Accent = ItemDataServices.Instance.GetAccent(ID);
            model.ID = Accent.ID;
            model.Name = Accent.Name;

            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(AccentActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var Accent = ItemDataServices.Instance.GetAccent(model.ID);
                ItemDataServices.Instance.DeleteAccent(Accent.ID);

            }
            return RedirectToAction("Index", "Accent");

        }
    }
}