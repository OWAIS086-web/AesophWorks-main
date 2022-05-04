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
    public class CuttingBoardController : Controller
    {
        // GET: CuttingBoard
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            CuttingBoardActionViewModel model = new CuttingBoardActionViewModel();
            if (ID != 0)
            {
                var cuttingboard = ItemServices.Instance.GetCuttingBoard(ID);
                model.ID = cuttingboard.ID;
                model.Name = cuttingboard.Name;
                model.FingerGroove = cuttingboard.FingerGroove;
                model.JuiceGroove = cuttingboard.JuiceGroove;
                model.TypeOfCuttingBoard = cuttingboard.TypeOfCuttingBoard;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(CuttingBoardActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var cuttingboard = ItemServices.Instance.GetCuttingBoard(model.ID);

                cuttingboard.ID = model.ID;
                cuttingboard.Name = model.Name;
                cuttingboard.TypeOfCuttingBoard = model.TypeOfCuttingBoard;
                cuttingboard.FingerGroove = model.FingerGroove;
                cuttingboard.JuiceGroove = model.JuiceGroove;
                ItemServices.Instance.UpdateItem(cuttingboard);

            }
            else
            {
                var cuttingboard = new CuttingBoard();
                cuttingboard.Name = model.Name;
                cuttingboard.TypeOfCuttingBoard = model.TypeOfCuttingBoard;
                cuttingboard.FingerGroove = model.FingerGroove;
                cuttingboard.JuiceGroove = model.JuiceGroove;
                ItemServices.Instance.SaveItem(cuttingboard);
            }
            return RedirectToAction("CuttingBoard", "Item");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            CuttingBoardActionViewModel model = new CuttingBoardActionViewModel();
            var cuttingBoard = ItemServices.Instance.GetCuttingBoard(ID);
            model.ID = cuttingBoard.ID;
            model.Name = cuttingBoard.Name;
            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(UsersActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var user = UserServices.Instance.GetUser(model.ID);
                UserServices.Instance.DeleteUser(user.ID);

            }
            return RedirectToAction("Users", "Admin");

        }
    }
}