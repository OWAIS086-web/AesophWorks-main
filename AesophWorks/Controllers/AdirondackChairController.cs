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
    public class AdirondackChairController : Controller
    {
        // GET: AdirondackChair
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            ItemActionViewModel model = new ItemActionViewModel();
            if (ID != 0)
            {
                var AdirondackChair = ItemServices.Instance.GetItem(ID);
                model.ID = AdirondackChair.ID;
                model.Name = AdirondackChair.Name;
                model.Font = AdirondackChair.Font;
                model.Customization = AdirondackChair.Customization;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(ItemActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var AdirondackChair = ItemServices.Instance.GetItem(model.ID);

                AdirondackChair.ID = model.ID;
                AdirondackChair.Name = model.Name;
                AdirondackChair.Font = model.Font;
                AdirondackChair.Customization = model.Customization;
                ItemServices.Instance.UpdateItem(AdirondackChair);

            }
            else
            {
                var AdirondackChair = new Item();
                AdirondackChair.Name = model.Name;
                AdirondackChair.Font = model.Font;
                AdirondackChair.Customization = model.Customization;
                ItemServices.Instance.SaveItem(AdirondackChair);
            }
            return RedirectToAction("AdirondackChairs", "Item");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            ItemActionViewModel model = new ItemActionViewModel();
            var AdirondackChair = ItemServices.Instance.GetItem(ID);
            model.ID = AdirondackChair.ID;
            model.Name = AdirondackChair.Name;
            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(ItemActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var AdirondackChair = ItemServices.Instance.GetItem(model.ID);
                ItemServices.Instance.DeleteItem(AdirondackChair.ID);

            }
            return RedirectToAction("AdirondackChairs", "Item");

        }
    }
}