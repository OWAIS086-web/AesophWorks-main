using AesophWorks.Services;
using AesophWorks.ViewModels;
using AesophWorks.Entities;
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
                sizeprice = size.Price;
            }
            if (woodtype != null)
            {
                woodtypeprice =  (woodtype.Price);
            }
            if(accent != null)
            {
                accentprice =  (accent.Price);
            }
            if(cutterbutter != null)
            {
                cutterbutterprice =  (cutterbutter.Price);
            }
            if(feet != null)
            {
                feetprice =  (feet.Price);

            }
            if (orderType != null)
            {
                orderTypeprice =  (orderType.Price);
            }
            if (giftBox != null)
            {
                giftBoxprice =  (giftBox.Price);
            }
            if (handle != null)
            {
                handleprice =  (handle.Price);
            }
            if (inlay != null)
            {
                inlayprice =  (inlay.Price);
            }


            Total += woodtypeprice + accentprice + sizeprice + cutterbutterprice+feetprice+orderTypeprice+giftBoxprice+handleprice+inlayprice;
            return Json(Total, JsonRequestBehavior.AllowGet);

        }



        [HttpPost]
        public ActionResult SaveOrder(MakeOrderViewModel model)
        {
            Double GrandTotal = 0;
            string InlayTextStyle = "";
            string InlayTextSpecification = "";
            var Item = ItemServices.Instance.GetItem(model.Item);
            var CutterButter = ItemDataServices.Instance.GetSelectedProductCutterButters(Item.ID, model.CutterButter);
            var WoodType = ItemDataServices.Instance.GetSelectedProductWoodTypes(Item.ID, model.WoodType);
            var Handle = ItemDataServices.Instance.GetSelectedProductHandles(Item.ID, model.Handle);
            var Inlay = ItemDataServices.Instance.GetSelectedProductInlays(Item.ID, model.Inlay);
            if(Inlay != null)
            {
                InlayTextStyle = model.InlayTextStyle;
                InlayTextSpecification = model.InlayTextSpecification;
            }
            var GiftBox = ItemDataServices.Instance.GetSelectedProductGiftBoxs(Item.ID, model.GiftBox);
            var Size = ItemDataServices.Instance.GetSelectedProductSizes(Item.ID, model.Size);
            var Accent = ItemDataServices.Instance.GetSelectedProductAccents(Item.ID, model.Accent);
            var OrderType = ItemDataServices.Instance.GetSelectedProductOrderTypes(Item.ID, model.OrderType);
            var User = UserServices.Instance.GetUser(int.Parse(Session["ID"].ToString()));
            var Feet = ItemDataServices.Instance.GetSelectedProductFeets(Item.ID, model.Feet);
            var Order = new Order();
            Order.Item = Item.Name;
            Order.GiftBox = GiftBox.Name;
            Order.GiftBoxPrice = GiftBox.Price;
            Order.Handle = Handle.Name;
            Order.HandPrice = Handle.Price;
            Order.WoodType = WoodType.Name;
            Order.WoodTypePrice = WoodType.Price;
            Order.Feet = Feet.Name;
            Order.FeetPrice = Feet.Price;
            Order.Inlay = Inlay.Name;
            Order.InlayTextStyle = InlayTextStyle;
            Order.InlayTextSpecification = InlayTextSpecification;
            Order.Size = Size.Name;
            Order.SizePrice = Size.Price;
            Order.CutterButter = CutterButter.Name;
            Order.CutterButterPrice = CutterButter.Price;
            Order.OrderType = OrderType.Name;
            Order.OrderTypePrice = OrderType.Price;
            Order.Accent = Accent.Name;
            Order.AccentPrice = Accent.Price;
            Order.Name = User.Name;

            GrandTotal = CutterButter.Price + GiftBox.Price +
                Handle.Price + Inlay.Price + 
                Feet.Price + Size.Price + 
                WoodType.Price + OrderType.Price + Accent.Price;
            Order.Total = GrandTotal;

            UserServices.Instance.SaveOrder(Order);


            
            return RedirectToAction("Dashboard", "User");
        }

    }
}