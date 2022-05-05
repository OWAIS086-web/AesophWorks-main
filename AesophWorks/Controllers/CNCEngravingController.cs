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
    public class CNCEngravingController : Controller
    {
        // GET: CNCEngraving
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            CNCEngravingActionViewModel model = new CNCEngravingActionViewModel();
            if (ID != 0)
            {
                var CNCEngraving = ItemServices.Instance.GetCNCEngraving(ID);
                model.ID = CNCEngraving.ID;
                model.Name = CNCEngraving.Name;
                model.Font = CNCEngraving.Font;
                model.Quantity = CNCEngraving.Quantity;
                model.Customization = CNCEngraving.Customization;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(CNCEngravingActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var CNCEngraving = ItemServices.Instance.GetCNCEngraving(model.ID);

                CNCEngraving.ID = model.ID;
                CNCEngraving.Name = model.Name;
                CNCEngraving.Quantity = model.Quantity;
                CNCEngraving.Font = model.Font;
                CNCEngraving.Customization = model.Customization;
                ItemServices.Instance.UpdateItem(CNCEngraving);

            }
            else
            {
                var CNCEngraving = new CNCEngraving();
                CNCEngraving.Name = model.Name;
                CNCEngraving.Quantity = model.Quantity;
                CNCEngraving.Font = model.Font;
                CNCEngraving.Customization = model.Customization;
                ItemServices.Instance.SaveItem(CNCEngraving);
            }
            return RedirectToAction("CNCEngraving", "Item");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            CNCEngravingActionViewModel model = new CNCEngravingActionViewModel();
            var CNCEngraving = ItemServices.Instance.GetCNCEngraving(ID);
            model.ID = CNCEngraving.ID;
            model.Name = CNCEngraving.Name;
            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(CNCEngravingActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var CNCEngraving = ItemServices.Instance.GetCNCEngraving(model.ID);
                ItemServices.Instance.DeleteCNCEngraving(CNCEngraving.ID);

            }
            return RedirectToAction("CNCEngraving", "Item");

        }
    }
}