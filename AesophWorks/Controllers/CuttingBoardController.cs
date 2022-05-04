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
                return View("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }
    }
}