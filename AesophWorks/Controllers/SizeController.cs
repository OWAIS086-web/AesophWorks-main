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
    public class SizeController : Controller
    {
        // GET: Size
      
        public ActionResult Index(string SearchTerm)
        {
            SizeListingViewModel model = new SizeListingViewModel();
            var SizeLsit = ItemDataServices.Instance.GetAllSizes(SearchTerm);
            List<MyList> myList = new List<MyList>();

            foreach (var item in SizeLsit)
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
            SizeActionViewModel model = new SizeActionViewModel();
            model.Items = ItemServices.Instance.GetAllItems("");
            if (ID != 0)
            {
                var Size = ItemDataServices.Instance.GetSize(ID);
                model.ID = Size.ID;
                model.Name = Size.Name;
                model.ItemID = Size.ItemID;
                model.Price = Size.Price;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(SizeActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var Size = ItemDataServices.Instance.GetSize(model.ID);

                Size.ID = model.ID;
                Size.Name = model.Name;
                Size.ItemID = model.ItemID;
                Size.Price = model.Price;
                ItemDataServices.Instance.UpdateSize(Size);

            }
            else
            {
                var Size = new Size();
                Size.ID = model.ID;
                Size.Name = model.Name;
                Size.ItemID = model.ItemID;
                Size.Price = model.Price;
                ItemDataServices.Instance.SaveSize(Size);
            }
            return RedirectToAction("Index", "Size");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            SizeActionViewModel model = new SizeActionViewModel();
            var Size = ItemDataServices.Instance.GetSize(ID);
            model.ID = Size.ID;
            model.Name = Size.Name;

            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(SizeActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var Size = ItemDataServices.Instance.GetSize(model.ID);
                ItemDataServices.Instance.DeleteSize(Size.ID);

            }
            return RedirectToAction("Index", "Size");

        }
    }
}