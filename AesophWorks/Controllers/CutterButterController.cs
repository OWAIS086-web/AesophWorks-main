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
    public class CutterButterController : Controller
    {
        // GET: CutterButter
        public ActionResult Index(string SearchTerm)
        {
            CutterButterListingViewModel model = new CutterButterListingViewModel();
            var CutterButterLsit = ItemDataServices.Instance.GetAllCutterButters(SearchTerm);
            List<MyList> myList = new List<MyList>();

            foreach (var item in CutterButterLsit)
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
            CutterButterActionViewModel model = new CutterButterActionViewModel();
            model.Items = ItemServices.Instance.GetAllItems("");
            if (ID != 0)
            {
                var CutterButter = ItemDataServices.Instance.GetCutterButter(ID);
                model.ID = CutterButter.ID;
                model.Name = CutterButter.Name;
                model.ItemID = CutterButter.ItemID;
                model.Price = CutterButter.Price;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(CutterButterActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var CutterButter = ItemDataServices.Instance.GetCutterButter(model.ID);

                CutterButter.ID = model.ID;
                CutterButter.Name = model.Name;
                CutterButter.ItemID = model.ItemID;
                CutterButter.Price = model.Price;
                ItemDataServices.Instance.UpdateCutterButter(CutterButter);

            }
            else
            {
                var CutterButter = new CutterButter();
                CutterButter.ID = model.ID;
                CutterButter.Name = model.Name;
                CutterButter.ItemID = model.ItemID;
                CutterButter.Price = model.Price;
                ItemDataServices.Instance.SaveCutterButter(CutterButter);
            }
            return RedirectToAction("Index", "CutterButter");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            CutterButterActionViewModel model = new CutterButterActionViewModel();
            var CutterButter = ItemDataServices.Instance.GetCutterButter(ID);
            model.ID = CutterButter.ID;
            model.Name = CutterButter.Name;

            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(CutterButterActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var CutterButter = ItemDataServices.Instance.GetCutterButter(model.ID);
                ItemDataServices.Instance.DeleteCutterButter(CutterButter.ID);

            }
            return RedirectToAction("Index", "CutterButter");

        }
    }
}