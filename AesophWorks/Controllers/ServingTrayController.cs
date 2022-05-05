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
    public class ServingTrayController : Controller
    {
        // GET: ServingTray
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            ServingTrayActionViewModel model = new ServingTrayActionViewModel();
            if (ID != 0)
            {
                var ServingTray = ItemServices.Instance.GetServingTray(ID);
                model.ID = ServingTray.ID;
                model.Name = ServingTray.Name;
                model.Handles = ServingTray.Handles;
                model.TypeOfServingTrays = ServingTray.TypeOfServingTrays;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(ServingTrayActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var ServingTray = ItemServices.Instance.GetServingTray(model.ID);

                ServingTray.ID = model.ID;
                ServingTray.Name = model.Name;
                ServingTray.TypeOfServingTrays = model.TypeOfServingTrays;
                ServingTray.Handles = model.Handles;
                ItemServices.Instance.UpdateItem(ServingTray);

            }
            else
            {
                var ServingTray = new ServingTrays();
                ServingTray.Name = model.Name;
                ServingTray.TypeOfServingTrays = model.TypeOfServingTrays;
                ServingTray.Handles = model.Handles;
                ServingTray.Type = model.Type;
                ItemServices.Instance.SaveItem(ServingTray);
            }
            return RedirectToAction("ServingTrays", "Item");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            ServingTrayActionViewModel model = new ServingTrayActionViewModel();
            var ServingTray = ItemServices.Instance.GetServingTray(ID);
            model.ID = ServingTray.ID;
            model.Name = ServingTray.Name;

            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(ServingTrayActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var ServingTray = ItemServices.Instance.GetServingTray(model.ID);
                ItemServices.Instance.DeleteServingTray(ServingTray.ID);

            }
            return RedirectToAction("ServingTrays", "Item");

        }
    }
}