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




        public ActionResult MakeOrder(int ID = 0)
        {
            MakeOrderViewModel model = new MakeOrderViewModel();
            if (ID == 0)
            {
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
            else
            {
                Double GrandTotal = 0;
                string InlayTextStyle = "";
                string InlayTextSpecification = "";

                var Order = UserServices.Instance.GetOrder(ID);
                var Item = ItemServices.Instance.GetItem(Order.Item);
                var CutterButter = ItemDataServices.Instance.GetCutterButter(Order.CutterButter);
                var WoodType = ItemDataServices.Instance.GetWoodType(Order.WoodType);
                var Handle = ItemDataServices.Instance.GetHandle(Order.Handle);
                var Inlay = ItemDataServices.Instance.GetInlay(Order.Inlay);
                if (Inlay != null)
                {
                    InlayTextStyle = Order.InlayTextStyle;
                    InlayTextSpecification = Order.InlayTextSpecification;
                }
                var GiftBox = ItemDataServices.Instance.GetGiftBox(Order.GiftBox);
                var Size = ItemDataServices.Instance.GetSize(Order.Size);
                var Accent = ItemDataServices.Instance.GetAccent(Order.Accent);
                var OrderType = ItemDataServices.Instance.GetOrderType(Order.OrderType);
                var Feet = ItemDataServices.Instance.GetFeet(Order.Feet);






                if (Order.GiftBox != null)
                {
                    Order.GiftBox = GiftBox.Name;
                    Order.GiftBoxPrice = GiftBox.Price;
                    model.GiftBoxes = ItemDataServices.Instance.GetAllGiftBoxs("");
                    model.GiftBox = GiftBox.ID;


                }
                if (Order.Handle != null)
                {
                    model.Handles = ItemDataServices.Instance.GetAllHandles("");
                    Order.Handle = Handle.Name;
                    Order.HandPrice = Handle.Price;
                    model.Handle = Handle.ID;
                }
                if (Order.WoodType != null)
                {
                    model.WoodTypes = ItemDataServices.Instance.GetAllWoodTypes("");

                    model.WoodType = WoodType.ID;


                }
                if (Order.Feet != null)
                {
                    model.Feets = ItemDataServices.Instance.GetAllFeets("");

                    model.Feet = Feet.ID;
                }
                if (Order.Inlay != null)
                {
                    model.Inlays = ItemDataServices.Instance.GetAllInlays("");
                    model.InlayTextSpecification = InlayTextSpecification;
                    model.InlayTextStyle = InlayTextStyle;
                    model.Inlay = Inlay.ID;
                }
                if (Order.Size != null)
                {
                    model.Sizes = ItemDataServices.Instance.GetAllSizes("");

                    model.Size = Size.ID;

                }
                if (Order.CutterButter != null)
                {
                    model.CutterButters = ItemDataServices.Instance.GetAllCutterButters("");

                    model.CutterButter = CutterButter.ID;

                }
                if (Order.OrderType != null)
                {
                    model.OrderTypes = ItemDataServices.Instance.GetAllOrderTypes("");

                    model.OrderType = OrderType.ID;
                }
                if (Order.Accent != null)
                {
                    model.Accents = ItemDataServices.Instance.GetAllAccents("");

                    model.Accent = Accent.ID;
                }
                model.ID = Order.ID;
                model.Name = Order.Name;
                //model.Item = Item.ID;
                model.Items = ItemServices.Instance.GetAllItems("");
                return PartialView("_EditDetailSection", model);
            }
        }

        public PartialViewResult GetData(int Product, int ID = 0)
        {
            MakeOrderViewModel model = new MakeOrderViewModel();
            model.ID = ID;
            if (model.ID == 0)
            {
                model.Items = ItemServices.Instance.GetAllItems("");
                TempData["ProductID"] = Product;
                /* model.Total = 10*/

                model.Inlays = ItemDataServices.Instance.GetSelectedProductInlays(Product);
                model.Sizes = ItemDataServices.Instance.GetSelectedProductSizes(Product);
                model.WoodTypes = ItemDataServices.Instance.GetSelectedProductWoodTypes(Product);
                model.Accents = ItemDataServices.Instance.GetSelectedProductAccents(Product);
                model.CutterButters = ItemDataServices.Instance.GetSelectedProductCutterButters(Product);
                model.Feets = ItemDataServices.Instance.GetSelectedProductFeets(Product);
                model.OrderTypes = ItemDataServices.Instance.GetSelectedProductOrderTypes(Product);
                model.Handles = ItemDataServices.Instance.GetSelectedProductHandles(Product);
                model.GiftBoxes = ItemDataServices.Instance.GetSelectedProductGiftBoxs(Product);
                return PartialView("_DetailSection", model);
            }
            else
            {
                Double GrandTotal = 0;
                string InlayTextStyle = "";
                string InlayTextSpecification = "";

                var Order = UserServices.Instance.GetOrder(ID);
                var Item = ItemServices.Instance.GetItem(Product);
                model.Inlays = ItemDataServices.Instance.GetSelectedProductInlays(Product);
                model.Sizes = ItemDataServices.Instance.GetSelectedProductSizes(Product);
                model.WoodTypes = ItemDataServices.Instance.GetSelectedProductWoodTypes(Product);
                model.Accents = ItemDataServices.Instance.GetSelectedProductAccents(Product);
                model.CutterButters = ItemDataServices.Instance.GetSelectedProductCutterButters(Product);
                model.Feets = ItemDataServices.Instance.GetSelectedProductFeets(Product);
                model.OrderTypes = ItemDataServices.Instance.GetSelectedProductOrderTypes(Product);
                model.Handles = ItemDataServices.Instance.GetSelectedProductHandles(Product);
                model.GiftBoxes = ItemDataServices.Instance.GetSelectedProductGiftBoxs(Product);
                //var CutterButter = ItemDataServices.Instance.GetSelectedProductCutterButters(Product);
                //var WoodType = ItemDataServices.Instance.GetSelectedProductWoodTypes(Product);
                //var Handle = ItemDataServices.Instance.GetSelectedProductHandles(Product);
                //var Inlay = ItemDataServices.Instance.GetSelectedProductInlays(Product);
                //if (Inlay != null)
                //{
                //    InlayTextStyle = Order.InlayTextStyle;
                //    InlayTextSpecification = Order.InlayTextSpecification;
                //}
                //var GiftBox = ItemDataServices.Instance.GetSelectedProductGiftBoxs(Product);
                //var Size = ItemDataServices.Instance.GetSelectedProductSizes(Item.ID,model.Size);
                //var Accent = ItemDataServices.Instance.GetSelectedProductAccents(Item.ID,model.Accent);
                //var OrderType = ItemDataServices.Instance.GetSelectedProductOrderTypes(Item.ID,model.OrderType);
                //var Feet = ItemDataServices.Instance.GetSelectedProductFeets(Item.ID,model.Feet);






                //if (model.GiftBox != 0)
                //{
                //    Order.GiftBox = GiftBox.Name;
                //    Order.GiftBoxPrice = GiftBox.Price;
                //    model.GiftBoxes = ItemDataServices.Instance.GetAllGiftBoxs("");
                //    model.GiftBox = GiftBox.ID;


                //}
                //if (model.Handle != 0)
                //{
                //    model.Handles = ItemDataServices.Instance.GetAllHandles("");
                //    Order.Handle = Handle.Name;
                //    Order.HandPrice = Handle.Price;
                //    model.Handle = Handle.ID;
                //}
                //if (model.WoodType != 0)
                //{
                //    model.WoodTypes = ItemDataServices.Instance.GetAllWoodTypes("");

                //    model.WoodType = WoodType.ID;


                //}
                //if (model.Feet != 0)
                //{
                //    model.Feets = ItemDataServices.Instance.GetAllFeets("");

                //    model.Feet = Feet.ID;
                //}
                //if (model.Inlay != 0)
                //{
                //    model.Inlays = ItemDataServices.Instance.GetAllInlays("");
                //    model.InlayTextSpecification = InlayTextSpecification;
                //    model.InlayTextStyle = InlayTextStyle;
                //    model.Inlay = Inlay.ID;
                //}
                //if (model.Size != 0)
                //{
                //    model.Sizes = ItemDataServices.Instance.GetAllSizes("");

                //    model.Size = Size.ID;

                //}
                //if (model.CutterButter != 0)
                //{
                //    model.CutterButters = ItemDataServices.Instance.GetAllCutterButters("");

                //    model.CutterButter = CutterButter.ID;

                //}
                //if (model.OrderType != 0)
                //{
                //    model.OrderTypes = ItemDataServices.Instance.GetAllOrderTypes("");

                //    model.OrderType = OrderType.ID;
                //}
                //if (model.Accent != 0)
                //{
                //    model.Accents = ItemDataServices.Instance.GetAllAccents("");

                //    model.Accent = Accent.ID;
                //}
                model.ID = Order.ID;
                model.Name = Order.Name;
                model.Item = Product;
                model.Items = ItemServices.Instance.GetAllItems("");
                return PartialView("_EditDetailSection", model);

            }

        }


        [HttpGet]
        public ActionResult GetTotal(int Product, int? WoodType, int? Size, int? Accent, int? CutterButter, int? Feet, int? OrderType, int? GiftBox, int? Handle, int? Inlay)
        {
            Double Total = 0;
            var size = ItemDataServices.Instance.GetSelectedProductSizes(Product, Size);
            var woodtype = ItemDataServices.Instance.GetSelectedProductWoodTypes(Product, WoodType);
            var accent = ItemDataServices.Instance.GetSelectedProductAccents(Product, Accent);
            var cutterbutter = ItemDataServices.Instance.GetSelectedProductCutterButters(Product, CutterButter);
            var feet = ItemDataServices.Instance.GetSelectedProductFeets(Product, Feet);
            var orderType = ItemDataServices.Instance.GetSelectedProductOrderTypes(Product, OrderType);
            var giftBox = ItemDataServices.Instance.GetSelectedProductGiftBoxs(Product, GiftBox);
            var handle = ItemDataServices.Instance.GetSelectedProductHandles(Product, Handle);
            var inlay = ItemDataServices.Instance.GetSelectedProductInlays(Product, Inlay);


            double sizeprice = 0;
            double woodtypeprice = 0;
            double accentprice = 0;
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
                woodtypeprice = (woodtype.Price);
            }
            if (accent != null)
            {
                accentprice = (accent.Price);
            }
            if (cutterbutter != null)
            {
                cutterbutterprice = (cutterbutter.Price);
            }
            if (feet != null)
            {
                feetprice = (feet.Price);

            }
            if (orderType != null)
            {
                orderTypeprice = (orderType.Price);
            }
            if (giftBox != null)
            {
                giftBoxprice = (giftBox.Price);
            }
            if (handle != null)
            {
                handleprice = (handle.Price);
            }
            if (inlay != null)
            {
                inlayprice = (inlay.Price);
            }


            Total += woodtypeprice + accentprice + sizeprice + cutterbutterprice + feetprice + orderTypeprice + giftBoxprice + handleprice + inlayprice;
            return Json(Total, JsonRequestBehavior.AllowGet);

        }



        [HttpPost]
        public ActionResult SaveOrder(MakeOrderViewModel model)
        {
            Double GrandTotal = 0;
            string InlayTextStyle = "";
            string InlayTextSpecification = "";
            Double CutterButterPrice = 0;
            Double GiftBoxPrice = 0;
            Double HandlePrice = 0;
            Double InlayPrice = 0;
            Double FeetPrice = 0;
            Double SizePrice = 0;
            Double WoodTypePrice = 0;
            Double OrderTypePrice = 0;
            Double AccentPrice = 0;
            var Item = ItemServices.Instance.GetItem(model.Item);
            var CutterButter = ItemDataServices.Instance.GetSelectedProductCutterButters(Item.ID, model.CutterButter);
            var WoodType = ItemDataServices.Instance.GetSelectedProductWoodTypes(Item.ID, model.WoodType);
            var Handle = ItemDataServices.Instance.GetSelectedProductHandles(Item.ID, model.Handle);
            var Inlay = ItemDataServices.Instance.GetSelectedProductInlays(Item.ID, model.Inlay);
            if (Inlay != null)
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
            if (GiftBox != null)
            {
                Order.GiftBox = GiftBox.Name;
                Order.GiftBoxPrice = GiftBox.Price;
                GiftBoxPrice = GiftBox.Price;
            }
            if (Handle != null)
            {
                Order.Handle = Handle.Name;
                Order.HandPrice = Handle.Price;
                HandlePrice = Handle.Price;
            }
            if (WoodType != null)
            {
                Order.WoodType = WoodType.Name;
                Order.WoodTypePrice = WoodType.Price;
                WoodTypePrice = WoodType.Price;
            }
            if (Feet != null)
            {
                Order.Feet = Feet.Name;
                Order.FeetPrice = Feet.Price;
                FeetPrice = Feet.Price;
            }
            if (Inlay != null)
            {
                Order.Inlay = Inlay.Name;
                Order.InlayPrice = Inlay.Price;
                InlayPrice = Inlay.Price;
                Order.InlayTextStyle = InlayTextStyle;
                Order.InlayTextSpecification = InlayTextSpecification;
            }
            if (Size != null)
            {
                Order.Size = Size.Name;
                Order.SizePrice = Size.Price;
                SizePrice = Size.Price;
            }
            if (CutterButter != null)
            {
                Order.CutterButter = CutterButter.Name;
                Order.CutterButterPrice = CutterButter.Price;
                CutterButterPrice = CutterButter.Price;
            }
            if (OrderType != null)
            {
                Order.OrderType = OrderType.Name;
                Order.OrderTypePrice = OrderType.Price;
                OrderTypePrice = OrderType.Price;
            }
            if (Accent != null)
            {
                Order.Accent = Accent.Name;
                Order.AccentPrice = Accent.Price;
                AccentPrice = Accent.Price;
            }
            Order.Name = User.Name;


            GrandTotal = CutterButterPrice + GiftBoxPrice + HandlePrice + InlayPrice + FeetPrice + SizePrice + WoodTypePrice + OrderTypePrice + AccentPrice;

            Order.Total = GrandTotal;

            UserServices.Instance.SaveOrder(Order);



            return RedirectToAction("Dashboard", "User");
        }

        [HttpPost]
        public ActionResult EditOrder(MakeOrderViewModel model)
        {
            Double GrandTotal = 0;
            string InlayTextStyle = "";
            string InlayTextSpecification = "";
            Double CutterButterPrice = 0;
            Double GiftBoxPrice = 0;
            Double HandlePrice = 0;
            Double InlayPrice = 0;
            Double FeetPrice = 0;
            Double SizePrice = 0;
            Double WoodTypePrice = 0;
            Double OrderTypePrice = 0;
            Double AccentPrice = 0;
            var Item = ItemServices.Instance.GetItem(model.Item);
            var CutterButter = ItemDataServices.Instance.GetSelectedProductCutterButters(Item.ID, model.CutterButter);
            var WoodType = ItemDataServices.Instance.GetSelectedProductWoodTypes(Item.ID, model.WoodType);
            var Handle = ItemDataServices.Instance.GetSelectedProductHandles(Item.ID, model.Handle);
            var Inlay = ItemDataServices.Instance.GetSelectedProductInlays(Item.ID, model.Inlay);
            if (Inlay != null)
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
            var Order = UserServices.Instance.GetOrder(model.ID);
            Order.Item = Item.Name;
            if (GiftBox != null)
            {
                Order.GiftBox = GiftBox.Name;
                Order.GiftBoxPrice = GiftBox.Price;
                GiftBoxPrice = GiftBox.Price;
            }
            if (Handle != null)
            {
                Order.Handle = Handle.Name;
                Order.HandPrice = Handle.Price;
                HandlePrice = Handle.Price;
            }
            if (WoodType != null)
            {
                Order.WoodType = WoodType.Name;
                Order.WoodTypePrice = WoodType.Price;
                WoodTypePrice = WoodType.Price;
            }
            if (Feet != null)
            {
                Order.Feet = Feet.Name;
                Order.FeetPrice = Feet.Price;
                FeetPrice = Feet.Price;
            }
            if (Inlay != null)
            {
                Order.Inlay = Inlay.Name;
                Order.InlayPrice = Inlay.Price;
                InlayPrice = Inlay.Price;
                Order.InlayTextStyle = InlayTextStyle;
                Order.InlayTextSpecification = InlayTextSpecification;
            }
            if (Size != null)
            {
                Order.Size = Size.Name;
                Order.SizePrice = Size.Price;
                SizePrice = Size.Price;
            }
            if (CutterButter != null)
            {
                Order.CutterButter = CutterButter.Name;
                Order.CutterButterPrice = CutterButter.Price;
                CutterButterPrice = CutterButter.Price;
            }
            if (OrderType != null)
            {
                Order.OrderType = OrderType.Name;
                Order.OrderTypePrice = OrderType.Price;
                OrderTypePrice = OrderType.Price;
            }
            if (Accent != null)
            {
                Order.Accent = Accent.Name;
                Order.AccentPrice = Accent.Price;
                AccentPrice = Accent.Price;
            }
            Order.Name = User.Name;


            GrandTotal = CutterButterPrice + GiftBoxPrice + HandlePrice + InlayPrice + FeetPrice + SizePrice + WoodTypePrice + OrderTypePrice + AccentPrice;

            Order.Total = GrandTotal;

            UserServices.Instance.UpdateOrder(Order);



            return RedirectToAction("Dashboard", "User");
        }



        public ActionResult ViewOrder(int ID = 0)
        {
            MakeOrderViewModel model = new MakeOrderViewModel();

            Double GrandTotal = 0;
            string InlayTextStyle = "";
            string InlayTextSpecification = "";

            var Order = UserServices.Instance.GetOrder(ID);
            var Item = ItemServices.Instance.GetItem(Order.Item);
            var CutterButter = ItemDataServices.Instance.GetCutterButter(Order.CutterButter);
            var WoodType = ItemDataServices.Instance.GetWoodType(Order.WoodType);
            var Handle = ItemDataServices.Instance.GetHandle(Order.Handle);
            var Inlay = ItemDataServices.Instance.GetInlay(Order.Inlay);
            if (Inlay != null)
            {
                InlayTextStyle = Order.InlayTextStyle;
                InlayTextSpecification = Order.InlayTextSpecification;
            }
            var GiftBox = ItemDataServices.Instance.GetGiftBox(Order.GiftBox);
            var Size = ItemDataServices.Instance.GetSize(Order.Size);
            var Accent = ItemDataServices.Instance.GetAccent(Order.Accent);
            var OrderType = ItemDataServices.Instance.GetOrderType(Order.OrderType);
            var Feet = ItemDataServices.Instance.GetFeet(Order.Feet);






            if (Order.GiftBox != null)
            {
                Order.GiftBox = GiftBox.Name;
                Order.GiftBoxPrice = GiftBox.Price;
                model.GiftBoxes = ItemDataServices.Instance.GetAllGiftBoxs("");
                model.GiftBox = GiftBox.ID;


            }
            if (Order.Handle != null)
            {
                model.Handles = ItemDataServices.Instance.GetAllHandles("");
                Order.Handle = Handle.Name;
                Order.HandPrice = Handle.Price;
                model.Handle = Handle.ID;
            }
            if (Order.WoodType != null)
            {
                model.WoodTypes = ItemDataServices.Instance.GetAllWoodTypes("");

                model.WoodType = WoodType.ID;


            }
            if (Order.Feet != null)
            {
                model.Feets = ItemDataServices.Instance.GetAllFeets("");

                model.Feet = Feet.ID;
            }
            if (Order.Inlay != null)
            {
                model.Inlays = ItemDataServices.Instance.GetAllInlays("");
                model.InlayTextSpecification = InlayTextSpecification;
                model.InlayTextStyle = InlayTextStyle;
                model.Inlay = Inlay.ID;
            }
            if (Order.Size != null)
            {
                model.Sizes = ItemDataServices.Instance.GetAllSizes("");

                model.Size = Size.ID;

            }
            if (Order.CutterButter != null)
            {
                model.CutterButters = ItemDataServices.Instance.GetAllCutterButters("");

                model.CutterButter = CutterButter.ID;

            }
            if (Order.OrderType != null)
            {
                model.OrderTypes = ItemDataServices.Instance.GetAllOrderTypes("");

                model.OrderType = OrderType.ID;
            }
            if (Order.Accent != null)
            {
                model.Accents = ItemDataServices.Instance.GetAllAccents("");

                model.Accent = Accent.ID;
            }
            model.ID = Order.ID;
            model.Name = Order.Name;
            model.Item = Item.ID;
            model.Items = ItemServices.Instance.GetAllItems("");
            return PartialView("ViewDetails", model);

        }
    }




}