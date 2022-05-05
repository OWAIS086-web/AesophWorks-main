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
    public class KniveController : Controller
    {
        // GET: Knive
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            KniveActionViewModel model = new KniveActionViewModel();
            if (ID != 0)
            {
                var Knive = ItemServices.Instance.GetKnive(ID);
                model.ID = Knive.ID;
                model.Name = Knive.Name;
                model.Handles = Knive.Handles;
                model.TypeOfKnives = Knive.TypeOfKnives;
                model.GiftBox = Knive.GiftBox;
                model.TypeOfKnivesOrder = Knive.TypeOfKnivesOrder;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(KniveActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var Knive = ItemServices.Instance.GetKnive(model.ID);

                Knive.ID = model.ID;
                Knive.Name = model.Name;
                Knive.GiftBox = model.GiftBox;
                Knive.TypeOfKnives = model.TypeOfKnives;
                Knive.TypeOfKnivesOrder = model.TypeOfKnivesOrder;
                Knive.Handles = model.Handles;
                ItemServices.Instance.UpdateItem(Knive);

            }
            else
            {
                var Knive = new Knives();
                Knive.Name = model.Name;
                Knive.TypeOfKnives = model.TypeOfKnives;
                Knive.GiftBox = model.GiftBox;
                Knive.TypeOfKnivesOrder = model.TypeOfKnivesOrder;
                Knive.Handles = model.Handles;
                ItemServices.Instance.SaveItem(Knive);
            }
            return RedirectToAction("Knives", "Item");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            KniveActionViewModel model = new KniveActionViewModel();
            var Knive = ItemServices.Instance.GetKnive(ID);
            model.ID = Knive.ID;
            model.Name = Knive.Name;

            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(KniveActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var Knive = ItemServices.Instance.GetKnive(model.ID);
                ItemServices.Instance.DeleteKnive(Knive.ID);

            }
            return RedirectToAction("Knives", "Item");

        }
    }
}