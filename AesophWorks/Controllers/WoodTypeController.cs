using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AesophWorks.Controllers
{
    public class WoodTypeController : Controller
    {
        // GET: WoodType
        public ActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public ActionResult Action(int ID = 0)
        //{
        //    ChautericeBoardActionViewModel model = new ChautericeBoardActionViewModel();
        //    if (ID != 0)
        //    {
        //        var ChautericeBoard = ItemServices.Instance.GetChautericeBoard(ID);
        //        model.ID = ChautericeBoard.ID;
        //        model.Name = ChautericeBoard.Name;
        //        model.Handles = ChautericeBoard.Handles;
        //        model.Type = ChautericeBoard.Type;
        //        model.TypeOfChautericeBoard = ChautericeBoard.TypeOfChautericeBoard;
        //        return PartialView("Action", model);

        //    }
        //    else
        //    {
        //        return View("Action", model);
        //    }
        //}



        //[HttpPost]
        //public ActionResult Action(ChautericeBoardActionViewModel model)
        //{
        //    if (model.ID != 0) //update record
        //    {
        //        var ChautericeBoard = ItemServices.Instance.GetChautericeBoard(model.ID);

        //        ChautericeBoard.ID = model.ID;
        //        ChautericeBoard.Name = model.Name;
        //        ChautericeBoard.TypeOfChautericeBoard = model.TypeOfChautericeBoard;
        //        ChautericeBoard.Handles = model.Handles;
        //        ChautericeBoard.Type = model.Type;
        //        ItemServices.Instance.UpdateItem(ChautericeBoard);

        //    }
        //    else
        //    {
        //        var ChautericeBoard = new ChautericeBoard();
        //        ChautericeBoard.Name = model.Name;
        //        ChautericeBoard.TypeOfChautericeBoard = model.TypeOfChautericeBoard;
        //        ChautericeBoard.Handles = model.Handles;
        //        ChautericeBoard.Type = model.Type;
        //        ItemServices.Instance.SaveItem(ChautericeBoard);
        //    }
        //    return RedirectToAction("ChautericeBoard", "Item");
        //}

        //[HttpGet]
        //public ActionResult Delete(int ID)
        //{
        //    ChautericeBoardActionViewModel model = new ChautericeBoardActionViewModel();
        //    var ChautericeBoard = ItemServices.Instance.GetChautericeBoard(ID);
        //    model.ID = ChautericeBoard.ID;
        //    model.Name = ChautericeBoard.Name;

        //    return View("_Delete", model);
        //}

        //[HttpPost]
        //public ActionResult Delete(ChautericeBoardActionViewModel model)
        //{

        //    if (model.ID != 0) //we are trying to delete a record
        //    {
        //        var ChautericeBoard = ItemServices.Instance.GetChautericeBoard(model.ID);
        //        ItemServices.Instance.DeleteChautericeBoard(ChautericeBoard.ID);

        //    }
        //    return RedirectToAction("ChautericeBoard", "Item");

        //}
    }
}