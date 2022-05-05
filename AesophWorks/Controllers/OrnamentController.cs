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
    public class OrnamentController : Controller
    {
        // GET: Ornament
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            OrnamentActionViewModel model = new OrnamentActionViewModel();
            if (ID != 0)
            {
                var Ornament = ItemServices.Instance.GetOrnament(ID);
                model.ID = Ornament.ID;
                model.Name = Ornament.Name;
                model.Shape = Ornament.Shape;
                model.Font = Ornament.Font;
                model.Customization = Ornament.Customization;
                model.Hanger = Ornament.Hanger;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }




        [HttpPost]
        public ActionResult Action(OrnamentActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var Ornament = ItemServices.Instance.GetOrnament(model.ID);

                Ornament.ID = model.ID;
                Ornament.Name = model.Name;
                Ornament.Shape = model.Shape;
                Ornament.Font = model.Font;
                Ornament.Hanger = model.Hanger;
                Ornament.Customization = model.Customization;
                ItemServices.Instance.UpdateItem(Ornament);

            }
            else
            {
                var Ornament = new Ornaments();
                Ornament.Name = model.Name;
                Ornament.Shape = model.Shape;
                Ornament.Font = model.Font;
                Ornament.Hanger = model.Hanger;
                ItemServices.Instance.SaveItem(Ornament);
            }
            return RedirectToAction("Ornaments", "Item");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            OrnamentActionViewModel model = new OrnamentActionViewModel();
            var Ornament = ItemServices.Instance.GetOrnament(ID);
            model.ID = Ornament.ID;
            model.Name = Ornament.Name;
            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(OrnamentActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var Ornament = ItemServices.Instance.GetOrnament(model.ID);
                ItemServices.Instance.DeleteOrnament(Ornament.ID);

            }
            return RedirectToAction("Ornaments", "Item");

        }
    }
}