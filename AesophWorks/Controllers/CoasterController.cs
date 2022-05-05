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
    public class CoasterController : Controller
    {
        // GET: Coaster
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            CoasterActionViewModel model = new CoasterActionViewModel();
            if (ID != 0)
            {
                var Coaster = ItemServices.Instance.GetCoaster(ID);
                model.ID = Coaster.ID;
                model.Name = Coaster.Name;
                model.Font = Coaster.Font;
                model.Shape = Coaster.Shape;
                model.Customization = Coaster.Customization;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(CoasterActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var Coaster = ItemServices.Instance.GetCoaster(model.ID);

                Coaster.ID = model.ID;
                Coaster.Name = model.Name;
                Coaster.Shape = model.Shape;
                Coaster.Font = model.Font;
                Coaster.Customization = model.Customization;
                ItemServices.Instance.UpdateItem(Coaster);

            }
            else
            {
                var Coaster = new Coasters();
                Coaster.Name = model.Name;
                Coaster.Shape = model.Shape;
                Coaster.Font = model.Font;
                Coaster.Customization = model.Customization;
                ItemServices.Instance.SaveItem(Coaster);
            }
            return RedirectToAction("Coasters", "Item");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            CoasterActionViewModel model = new CoasterActionViewModel();
            var Coaster = ItemServices.Instance.GetCoaster(ID);
            model.ID = Coaster.ID;
            model.Name = Coaster.Name;
            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(CoasterActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var Coaster = ItemServices.Instance.GetCoaster(model.ID);
                ItemServices.Instance.DeleteCoaster(Coaster.ID);

            }
            return RedirectToAction("Coasters", "Item");

        }
    }
}