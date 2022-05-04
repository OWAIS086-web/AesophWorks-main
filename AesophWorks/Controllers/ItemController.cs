using AesophWorks.Services;
using AesophWorks.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AesophWorks.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        //bool isInRole = UserServices.Instance.CheckRoleForAdmin();
        public ActionResult Index()
        {
            //if (isInRole == false)
            //{
            //    return RedirectToAction("LogOut", "Home");
            //}
            //else
            //{
                return View();
            
        }


        public ActionResult CuttingBoard(string SearchTerm)
        {
            CuttingBoardListingViewModel model = new CuttingBoardListingViewModel();
            model.CuttingBoards = ItemServices.Instance.GetAllCuttingBoard(SearchTerm);
            return View(model);
        }

        public ActionResult ServingTrays()
        {
            return View();
        }

        public ActionResult ChautericeBoard()
        {
            return View();
        }

        public ActionResult Ornaments()
        {
            return View();
        }

        public ActionResult WeddingFavors()
        {
            return View();
        }

        public ActionResult Coasters()
        {
            return View();
        }

        public ActionResult AdirondackChairs()
        {
            return View();
        }

        public ActionResult CNCEngraving()
        {
            return View();
        }

        public ActionResult Knives()
        {
            return View();
        }
    }
}