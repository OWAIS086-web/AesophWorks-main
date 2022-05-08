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
    public class InlayController : Controller
    {
        // GET: Inlay
        public ActionResult Index(string SearchTerm)
        {
            InlayListingViewModel model = new InlayListingViewModel();
            var InlayLsit = ItemDataServices.Instance.GetAllInlays(SearchTerm);
            List<MyList> myList = new List<MyList>();

            foreach (var item in InlayLsit)
            {
                var Item = ItemServices.Instance.GetItem(item.ItemID);
                myList.Add(new MyList { ID = item.ID, ItemID = item.ItemID, Item = Item, Name = item.Name, Price = item.Price});
            }
            model.MyLists = myList;
            return View(model);
        }

        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            InlayActionViewModel model = new InlayActionViewModel();
            model.Items = ItemServices.Instance.GetAllItems("");
            if (ID != 0)
            {
                var Inlay = ItemDataServices.Instance.GetInlay(ID);
                model.ID = Inlay.ID;
                model.Name = Inlay.Name;
                model.ItemID = Inlay.ItemID;
                model.Price = Inlay.Price;
                
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(InlayActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var Inlay = ItemDataServices.Instance.GetInlay(model.ID);

                Inlay.ID = model.ID;
                Inlay.Name = model.Name;
                Inlay.ItemID = model.ItemID;
                Inlay.Price = model.Price;
  
                ItemDataServices.Instance.UpdateInlay(Inlay);

            }
            else
            {
                var Inlay = new Inlay();
                Inlay.ID = model.ID;
                Inlay.Name = model.Name;
                Inlay.ItemID = model.ItemID;
                Inlay.Price = model.Price;
          
                ItemDataServices.Instance.SaveInlay(Inlay);
            }
            return RedirectToAction("Index", "Inlay");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            InlayActionViewModel model = new InlayActionViewModel();
            var Inlay = ItemDataServices.Instance.GetInlay(ID);
            model.ID = Inlay.ID;
            model.Name = Inlay.Name;

            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(InlayActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var Inlay = ItemDataServices.Instance.GetInlay(model.ID);
                ItemDataServices.Instance.DeleteInlay(Inlay.ID);

            }
            return RedirectToAction("Index", "Inlay");

        }
    }
}