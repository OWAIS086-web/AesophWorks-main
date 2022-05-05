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
            ItemListingViewModel model = new ItemListingViewModel();
            //model.Items = ItemServices.Instance.GetAllCuttingBoard(SearchTerm);
            return View(model);
        }

        public ActionResult ServingTrays(string SearchTerm)
        {
            ItemListingViewModel model = new ItemListingViewModel();
            //model.ServingTrays = ItemServices.Instance.GetAllServingTrays(SearchTerm);
            return View(model);
        }

        public ActionResult ChautericeBoard(string SearchTerm)
        {
            ItemListingViewModel model = new ItemListingViewModel();
            //model.ChautericeBoards = ItemServices.Instance.GetAllChautericeBoards(SearchTerm);
            return View(model);
        }

        public ActionResult Ornaments(string SearchTerm)
        {
            ItemListingViewModel model = new ItemListingViewModel();
            //model.Ornaments = ItemServices.Instance.GetAllOrnaments(SearchTerm);
            return View(model);
        }

        public ActionResult WeddingFavors(string SearchTerm)
        {
            ItemListingViewModel model = new ItemListingViewModel();
            //model.WeddingFavors = ItemServices.Instance.GetAllWeddingFavors(SearchTerm);
            return View(model);
        }

        public ActionResult Coasters(string SearchTerm)
        {
            ItemListingViewModel model = new ItemListingViewModel();
            //model.Coasters = ItemServices.Instance.GetAllCoasters(SearchTerm);
            return View(model);
        }

        public ActionResult AdirondackChairs(string SearchTerm)
        {
            ItemListingViewModel model = new ItemListingViewModel();
            //model.AdirondackChairs = ItemServices.Instance.GetAllAdirondackChairs(SearchTerm);
            return View(model);
        }

        public ActionResult CNCEngraving(string SearchTerm)
        {
            ItemListingViewModel model = new ItemListingViewModel();
            //model.CNCEngravings = ItemServices.Instance.GetAllCNCEngravings(SearchTerm);
            return View(model);
        }

        public ActionResult Knives(string SearchTerm)
        {
            ItemListingViewModel model = new ItemListingViewModel();
            //model.Knives = ItemServices.Instance.GetAllKnives(SearchTerm);
            return View(model);
        }
    }
}