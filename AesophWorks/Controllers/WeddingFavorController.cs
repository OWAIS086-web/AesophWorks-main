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
    public class WeddingFavorController : Controller
    {
        // GET: WeddingFavor
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            WeddingFavorActionViewModel model = new WeddingFavorActionViewModel();
            if (ID != 0)
            {
                var WeddingFavor = ItemServices.Instance.GetWeddingFavor(ID);
                model.ID = WeddingFavor.ID;
                model.Name = WeddingFavor.Name;
                model.Handles = WeddingFavor.Handles;
                model.TypeOfWeddingFavor = WeddingFavor.TypeOfWeddingFavor;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(WeddingFavorActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var WeddingFavor = ItemServices.Instance.GetWeddingFavor(model.ID);

                WeddingFavor.ID = model.ID;
                WeddingFavor.Name = model.Name;
                WeddingFavor.TypeOfWeddingFavor = model.TypeOfWeddingFavor;
                WeddingFavor.Handles = model.Handles;
                ItemServices.Instance.UpdateItem(WeddingFavor);

            }
            else
            {
                var WeddingFavor = new WeddingFavor();
                WeddingFavor.Name = model.Name;
                WeddingFavor.TypeOfWeddingFavor = model.TypeOfWeddingFavor;
                WeddingFavor.Handles = model.Handles;
                ItemServices.Instance.SaveItem(WeddingFavor);
            }
            return RedirectToAction("WeddingFavors", "Item");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            WeddingFavorActionViewModel model = new WeddingFavorActionViewModel();
            var WeddingFavor = ItemServices.Instance.GetWeddingFavor(ID);
            model.ID = WeddingFavor.ID;
            model.Name = WeddingFavor.Name;

            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(WeddingFavorActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var WeddingFavor = ItemServices.Instance.GetWeddingFavor(model.ID);
                ItemServices.Instance.DeleteWeddingFavor(WeddingFavor.ID);

            }
            return RedirectToAction("WeddingFavors", "Item");

        }
    }
}