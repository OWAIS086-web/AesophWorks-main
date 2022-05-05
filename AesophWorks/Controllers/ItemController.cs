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

        public ActionResult ServingTrays(string SearchTerm)
        {
            ServingTrayListingViewModel model = new ServingTrayListingViewModel();
            model.ServingTrays = ItemServices.Instance.GetAllServingTrays(SearchTerm);
            return View(model);
        }

        public ActionResult ChautericeBoard(string SearchTerm)
        {
            ChautericeBoardListingViewModel model = new ChautericeBoardListingViewModel();
            model.ChautericeBoards = ItemServices.Instance.GetAllChautericeBoards(SearchTerm);
            return View(model);
        }

        public ActionResult Ornaments(string SearchTerm)
        {
            OrnamentListingViewModel model = new OrnamentListingViewModel();
            model.Ornaments = ItemServices.Instance.GetAllOrnaments(SearchTerm);
            return View(model);
        }

        public ActionResult WeddingFavors(string SearchTerm)
        {
            WeddingFavorListingViewModel model = new WeddingFavorListingViewModel();
            model.WeddingFavors = ItemServices.Instance.GetAllWeddingFavors(SearchTerm);
            return View(model);
        }

        public ActionResult Coasters(string SearchTerm)
        {
            CoasterListingViewModel model = new CoasterListingViewModel();
            model.Coasters = ItemServices.Instance.GetAllCoasters(SearchTerm);
            return View(model);
        }

        public ActionResult AdirondackChairs(string SearchTerm)
        {
            AdirondackChairListingViewModel model = new AdirondackChairListingViewModel();
            model.AdirondackChairs = ItemServices.Instance.GetAllAdirondackChairs(SearchTerm);
            return View(model);
        }

        public ActionResult CNCEngraving(string SearchTerm)
        {
            CNCEngravingListingViewModel model = new CNCEngravingListingViewModel();
            model.CNCEngravings = ItemServices.Instance.GetAllCNCEngravings(SearchTerm);
            return View(model);
        }

        public ActionResult Knives(string SearchTerm)
        {
            KniveListingViewModel model = new KniveListingViewModel();
            model.Knives = ItemServices.Instance.GetAllKnives(SearchTerm);
            return View(model);
        }
    }
}