using AesophWorks.Services;
using AesophWorks.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AesophWorks.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Dashboard()
        {
            return View();
        }


        public ActionResult MakeOrder()
        {
            MakeOrderViewModel model = new MakeOrderViewModel();
            model.Items = ItemServices.Instance.GetAllItems("");
            model.Inlays = ItemDataServices.Instance.GetAllInlays("");
            model.Sizes = ItemDataServices.Instance.GetAllSizes("");
            model.WoodTypes = ItemDataServices.Instance.GetAllWoodTypes("");
            model.Accents = ItemDataServices.Instance.GetAllAccents("");
            model.CutterButters = ItemDataServices.Instance.GetAllCutterButters("");
            model.Feets = ItemDataServices.Instance.GetAllFeets("");
            model.OrderTypes = ItemDataServices.Instance.GetAllOrderTypes("");
            model.Handles = ItemDataServices.Instance.GetAllHandles("");
            model.GiftBoxes = ItemDataServices.Instance.GetAllGiftBoxs("");
            model.Total = 0;
            return View(model);
        }

        public PartialViewResult GetData(int Product)
        {

            MakeOrderViewModel model = new MakeOrderViewModel();
         
            model.Items = ItemServices.Instance.GetAllItems("");
            TempData["ProductID"] = Product;
           /* model.Total = 10*/;
            model.Inlays =      ItemDataServices.Instance.GetSelectedProductInlays(Product);
            model.Sizes =       ItemDataServices.Instance.GetSelectedProductSizes(Product);
            model.WoodTypes =   ItemDataServices.Instance.GetSelectedProductWoodTypes(Product);
            model.Accents =     ItemDataServices.Instance.GetSelectedProductAccents(Product);
            model.CutterButters=ItemDataServices.Instance.GetSelectedProductCutterButters(Product);
            model.Feets =       ItemDataServices.Instance.GetSelectedProductFeets(Product);
            model.OrderTypes = ItemDataServices.Instance.GetSelectedProductOrderTypes(Product);
            model.Handles = ItemDataServices.Instance.GetSelectedProductHandles(Product);
            model.GiftBoxes = ItemDataServices.Instance.GetSelectedProductGiftBoxs(Product);
            return PartialView("_DetailSection",model);
        }


        [HttpGet]
        public ActionResult GetTotal(int Product, int? WoodType, int? Size, int? Accent, int? CutterButter, int? Feet, int? OrderType, int? GiftBox, int? Handle, int? Inlay)
        {
            Double Total = 0;
            var size =  ItemDataServices.Instance.GetSelectedProductSizes(Product,Size);
            var woodtype =  ItemDataServices.Instance.GetSelectedProductWoodTypes(Product,WoodType);
            var accent = ItemDataServices.Instance.GetSelectedProductAccents(Product,Accent);
            var cutterbutter = ItemDataServices.Instance.GetSelectedProductCutterButters(Product,CutterButter);
            var feet =  ItemDataServices.Instance.GetSelectedProductFeets(Product,Feet);
            var orderType = ItemDataServices.Instance.GetSelectedProductOrderTypes(Product, OrderType);
            var giftBox = ItemDataServices.Instance.GetSelectedProductGiftBoxs(Product, GiftBox);
            var handle = ItemDataServices.Instance.GetSelectedProductHandles(Product, Handle);
            var inlay = ItemDataServices.Instance.GetSelectedProductInlays(Product, Inlay);


            double sizeprice =         0;
            double woodtypeprice =     0;
            double accentprice =       0;
            double cutterbutterprice = 0;
            double feetprice = 0;
            double orderTypeprice = 0;
            double giftBoxprice = 0;
            double handleprice = 0;
            double inlayprice = 0;
            if (size != null)
            {
                sizeprice = float.Parse(size.Price);
            }
            if (woodtype != null)
            {
                woodtypeprice = float.Parse(woodtype.Price);
            }
            if(accent != null)
            {
                accentprice = float.Parse(accent.Price);
            }
            if(cutterbutter != null)
            {
                cutterbutterprice = float.Parse(cutterbutter.Price);
            }
            if(feet != null)
            {
                feetprice = float.Parse(feet.Price);

            }
            if (orderType != null)
            {
                orderTypeprice = float.Parse(orderType.Price);
            }
            if (giftBox != null)
            {
                giftBoxprice = float.Parse(giftBox.Price);
            }
            if (handle != null)
            {
                handleprice = float.Parse(handle.Price);
            }
            if (inlay != null)
            {
                inlayprice = float.Parse(inlay.Price);
            }


            Total += woodtypeprice + accentprice + sizeprice + cutterbutterprice+feetprice+orderTypeprice+giftBoxprice+handleprice+inlayprice;
            return Json(Total, JsonRequestBehavior.AllowGet);

        }


    }
}