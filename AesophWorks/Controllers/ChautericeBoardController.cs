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
    public class ChautericeBoardController : Controller
    {
        // GET: ChautericeBoard
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
                var ChautericeBoard = ItemServices.Instance.GetItem(ID);
                model.ID = ChautericeBoard.ID;
                model.Name = ChautericeBoard.Name;
                model.Handles = ChautericeBoard.Handles;
                model.Type = ChautericeBoard.Type;
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
                var ChautericeBoard = ItemServices.Instance.GetItem(model.ID);

                ChautericeBoard.ID = model.ID;
                ChautericeBoard.Name = model.Name;
                ChautericeBoard.Handles = model.Handles;
                ChautericeBoard.Type = model.Type;
                ItemServices.Instance.UpdateItem(ChautericeBoard);

            }
            else
            {
                var ChautericeBoard = new Item();
                ChautericeBoard.Name = model.Name;
                ChautericeBoard.Handles = model.Handles;
                ChautericeBoard.Type = model.Type;
                ItemServices.Instance.SaveItem(ChautericeBoard);
            }
            return RedirectToAction("ChautericeBoard", "Item");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            ItemActionViewModel model = new ItemActionViewModel();
            var ChautericeBoard = ItemServices.Instance.GetItem(ID);
            model.ID = ChautericeBoard.ID;
            model.Name = ChautericeBoard.Name;

            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(ItemActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var ChautericeBoard = ItemServices.Instance.GetItem(model.ID);
                ItemServices.Instance.DeleteItem(ChautericeBoard.ID);

            }
            return RedirectToAction("ChautericeBoard", "Item");

        }
    }
}