using AesophWorks.Database;
using AesophWorks.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AesophWorks.Services
{
    public class ItemDataServices
    {
        #region Singleton
        public static ItemDataServices Instance
        {
            get
            {
                if (instance == null) instance = new ItemDataServices();
                return instance;
            }
        }
        private static ItemDataServices instance { get; set; }
        private ItemDataServices()
        {
        }
        #endregion

        #region WoodTypeCRUD
        public List<WoodType> GetAllWoodTypes(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.WoodTypes.Where(x => x.Name.Contains(SearchTerm) ).ToList();
                }
                else
                {
                    return context.WoodTypes.ToList();
                }
            }
        }
        public List<WoodType> GetSelectedProductWoodTypes(int ItemID)
        {

            using (var context = new AWContext())
            {
                if (ItemID != 0)
                {
                    return context.WoodTypes.Where(x => x.ItemID == ItemID).ToList();
                }
                else
                {
                    return context.WoodTypes.ToList();
                }
            }
        }
        public WoodType GetWoodType(int ID)
        {
            using(var context= new AWContext())
            {
                return context.WoodTypes.Find(ID);
            }
        }
        public void SaveWoodType(WoodType woodType)
        {
            using(var context = new AWContext())
            {
                context.WoodTypes.Add(woodType);
                context.SaveChanges();
            }
        }
        public void UpdateWoodType(WoodType WoodType)
        {
            using (var context = new AWContext())
            {
                context.Entry(WoodType).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteWoodType(int ID)
        {
            using (var context = new AWContext())
            {

                var WoodType = context.WoodTypes.Find(ID);
                context.WoodTypes.Remove(WoodType);
                context.SaveChanges();
            }
        }

        public WoodType GetSelectedProductWoodTypes(int ItemID, int? WoodTypeID)
        {

            using (var context = new AWContext())
            {
                return context.WoodTypes.Where(x => x.ItemID == ItemID && x.ID == WoodTypeID).FirstOrDefault();
            }
        }


        #endregion

        #region SizeCRUD
        public List<Size> GetAllSizes(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.Sizes.Where(x => x.Name.Contains(SearchTerm)).ToList();
                }
                else
                {
                    return context.Sizes.ToList();
                }
            }
        }
        public Size GetSize(int ID)
        {
            using (var context = new AWContext())
            {
                return context.Sizes.Find(ID);
            }
        }
        public void SaveSize(Size Size)
        {
            using (var context = new AWContext())
            {
                context.Sizes.Add(Size);
                context.SaveChanges();
            }
        }
        public void UpdateSize(Size Size)
        {
            using (var context = new AWContext())
            {
                context.Entry(Size).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteSize(int ID)
        {
            using (var context = new AWContext())
            {

                var Size = context.Sizes.Find(ID);
                context.Sizes.Remove(Size);
                context.SaveChanges();
            }
        }

        public List<Size> GetSelectedProductSizes(int ItemID)
        {

            using (var context = new AWContext())
            {
                if (ItemID != 0)
                {
                    return context.Sizes.Where(x => x.ItemID == ItemID).ToList();
                }
                else
                {
                    return context.Sizes.ToList();
                }
            }
        }
        public Size GetSelectedProductSizes(int ItemID, int? SizeID)
        {

            using (var context = new AWContext())
            {
                return context.Sizes.Where(x => x.ItemID == ItemID && x.ID == SizeID).FirstOrDefault();
            }
        }


        #endregion

        #region InlayCRUD
        public List<Inlay> GetAllInlays(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.Inlays.Where(x => x.Name.Contains(SearchTerm)).ToList();
                }
                else
                {
                    return context.Inlays.ToList();
                }
            }
        }

        public List<Inlay> GetSelectedProductInlays(int ItemID)
        {

            using (var context = new AWContext())
            {
                if (ItemID != 0)
                {
                    return context.Inlays.Where(x => x.ItemID == ItemID).ToList();
                }
                else
                {
                    return context.Inlays.ToList();
                }
            }
        }
        public Inlay GetInlay(int ID)
        {
            using (var context = new AWContext())
            {
                return context.Inlays.Find(ID);
            }
        }
        public void SaveInlay(Inlay Inlay)
        {
            using (var context = new AWContext())
            {
                context.Inlays.Add(Inlay);
                context.SaveChanges();
            }
        }
        public void UpdateInlay(Inlay Inlay)
        {
            using (var context = new AWContext())
            {
                context.Entry(Inlay).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteInlay(int ID)
        {
            using (var context = new AWContext())
            {

                var Inlay = context.Inlays.Find(ID);
                context.Inlays.Remove(Inlay);
                context.SaveChanges();
            }
        }
        public Inlay GetSelectedProductInlays(int ItemID, int? InlayID)
        {

            using (var context = new AWContext())
            {
                return context.Inlays.Where(x => x.ItemID == ItemID && x.ID == InlayID).FirstOrDefault();
            }
        }


        #endregion

        #region AccentCRUD
        public List<Accent> GetAllAccents(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.Accents.Where(x => x.Name.Contains(SearchTerm)).ToList();
                }
                else
                {
                    return context.Accents.ToList();
                }
            }
        }
        public Accent GetAccent(int ID)
        {
            using (var context = new AWContext())
            {
                return context.Accents.Find(ID);
            }
        }
        public void SaveAccent(Accent Accent)
        {
            using (var context = new AWContext())
            {
                context.Accents.Add(Accent);
                context.SaveChanges();
            }
        }
        public void UpdateAccent(Accent Accent)
        {
            using (var context = new AWContext())
            {
                context.Entry(Accent).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteAccent(int ID)
        {
            using (var context = new AWContext())
            {

                var Accent = context.Accents.Find(ID);
                context.Accents.Remove(Accent);
                context.SaveChanges();
            }
        }
        public List<Accent> GetSelectedProductAccents(int ItemID)
        {

            using (var context = new AWContext())
            {
                if (ItemID != 0)
                {
                    return context.Accents.Where(x => x.ItemID == ItemID).ToList();
                }
                else
                {
                    return context.Accents.ToList();
                }
            }
        }
        public Accent GetSelectedProductAccents(int ItemID, int? AccentID)
        {
            using (var context = new AWContext())
            {
                return context.Accents.Where(x => x.ItemID == ItemID && x.ID == AccentID).FirstOrDefault();
            }
        }
        #endregion

        #region CutterButterCRUD
        public List<CutterButter> GetAllCutterButters(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.CutterButters.Where(x => x.Name.Contains(SearchTerm)).ToList();
                }
                else
                {
                    return context.CutterButters.ToList();
                }
            }
        }
        public CutterButter GetCutterButter(int ID)
        {
            using (var context = new AWContext())
            {
                return context.CutterButters.Find(ID);
            }
        }
        public void SaveCutterButter(CutterButter CutterButter)
        {
            using (var context = new AWContext())
            {
                context.CutterButters.Add(CutterButter);
                context.SaveChanges();
            }
        }
        public void UpdateCutterButter(CutterButter CutterButter)
        {
            using (var context = new AWContext())
            {
                context.Entry(CutterButter).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteCutterButter(int ID)
        {
            using (var context = new AWContext())
            {

                var CutterButter = context.CutterButters.Find(ID);
                context.CutterButters.Remove(CutterButter);
                context.SaveChanges();
            }
        }
        public List<CutterButter> GetSelectedProductCutterButters(int ItemID)
        {

            using (var context = new AWContext())
            {
                if (ItemID != 0)
                {
                    return context.CutterButters.Where(x => x.ItemID == ItemID).ToList();
                }
                else
                {
                    return context.CutterButters.ToList();
                }
            }
        }

        public CutterButter GetSelectedProductCutterButters(int ItemID, int? CutterButterID)
        {

            using (var context = new AWContext())
            {
                return context.CutterButters.Where(x => x.ItemID == ItemID && x.ID == CutterButterID).FirstOrDefault();
            }
        }

        #endregion

        #region FeetCRUD
        public List<Feet> GetAllFeets(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.Feets.Where(x => x.Name.Contains(SearchTerm)).ToList();
                }
                else
                {
                    return context.Feets.ToList();
                }
            }
        }
        public Feet GetFeet(int ID)
        {
            using (var context = new AWContext())
            {
                return context.Feets.Find(ID);
            }
        }
        public void SaveFeet(Feet Feet)
        {
            using (var context = new AWContext())
            {
                context.Feets.Add(Feet);
                context.SaveChanges();
            }
        }
        public void UpdateFeet(Feet Feet)
        {
            using (var context = new AWContext())
            {
                context.Entry(Feet).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteFeet(int ID)
        {
            using (var context = new AWContext())
            {

                var Feet = context.Feets.Find(ID);
                context.Feets.Remove(Feet);
                context.SaveChanges();
            }
        }
        public List<Feet> GetSelectedProductFeets(int ItemID)
        {

            using (var context = new AWContext())
            {
                if (ItemID != 0)
                {
                    return context.Feets.Where(x => x.ItemID == ItemID).ToList();
                }
                else
                {
                    return context.Feets.ToList();
                }
            }
        }

        public Feet GetSelectedProductFeets(int ItemID, int? FeetID)
        {

            using (var context = new AWContext())
            {
                return context.Feets.Where(x => x.ItemID == ItemID && x.ID == FeetID).FirstOrDefault();
            }
        }


        #endregion

        #region OrderTypeCRUD
        public List<OrderType> GetAllOrderTypes(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.OrderTypes.Where(x => x.Name.Contains(SearchTerm)).ToList();
                }
                else
                {
                    return context.OrderTypes.ToList();
                }
            }
        }
        public OrderType GetOrderType(int ID)
        {
            using (var context = new AWContext())
            {
                return context.OrderTypes.Find(ID);
            }
        }
        public void SaveOrderType(OrderType OrderType)
        {
            using (var context = new AWContext())
            {
                context.OrderTypes.Add(OrderType);
                context.SaveChanges();
            }
        }
        public void UpdateOrderType(OrderType OrderType)
        {
            using (var context = new AWContext())
            {
                context.Entry(OrderType).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteOrderType(int ID)
        {
            using (var context = new AWContext())
            {

                var OrderType = context.OrderTypes.Find(ID);
                context.OrderTypes.Remove(OrderType);
                context.SaveChanges();
            }
        }
        public List<OrderType> GetSelectedProductOrderTypes(int ItemID)
        {

            using (var context = new AWContext())
            {
                if (ItemID != 0)
                {
                    return context.OrderTypes.Where(x => x.ItemID == ItemID).ToList();
                }
                else
                {
                    return context.OrderTypes.ToList();
                }
            }
        }

        public OrderType GetSelectedProductOrderTypes(int ItemID, int? OrderTypeID)
        {

            using (var context = new AWContext())
            {
                return context.OrderTypes.Where(x => x.ItemID == ItemID && x.ID == OrderTypeID).FirstOrDefault();
            }
        }

        #endregion

        #region HandleCrud
        public List<Handle> GetAllHandles(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.Handles.Where(x => x.Name.Contains(SearchTerm)).ToList();
                }
                else
                {
                    return context.Handles.ToList();
                }
            }
        }
        public Handle GetHandle(int ID)
        {
            using (var context = new AWContext())
            {
                return context.Handles.Find(ID);
            }
        }
        public void SaveHandle(Handle Handle)
        {
            using (var context = new AWContext())
            {
                context.Handles.Add(Handle);
                context.SaveChanges();
            }
        }
        public void UpdateHandle(Handle Handle)
        {
            using (var context = new AWContext())
            {
                context.Entry(Handle).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteHandle(int ID)
        {
            using (var context = new AWContext())
            {

                var Handle = context.Handles.Find(ID);
                context.Handles.Remove(Handle);
                context.SaveChanges();
            }
        }
        public List<Handle> GetSelectedProductHandles(int ItemID)
        {

            using (var context = new AWContext())
            {
                if (ItemID != 0)
                {
                    return context.Handles.Where(x => x.ItemID == ItemID).ToList();
                }
                else
                {
                    return context.Handles.ToList();
                }
            }
        }

        public Handle GetSelectedProductHandles(int ItemID, int? HandleID)
        {

            using (var context = new AWContext())
            {
                return context.Handles.Where(x => x.ItemID == ItemID && x.ID == HandleID).FirstOrDefault();
            }
        }


        #endregion

        #region GiftBoxCRUD
        public List<GiftBox> GetAllGiftBoxs(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.GiftBoxes.Where(x => x.Name.Contains(SearchTerm)).ToList();
                }
                else
                {
                    return context.GiftBoxes.ToList();
                }
            }
        }
        public GiftBox GetGiftBox(int ID)
        {
            using (var context = new AWContext())
            {
                return context.GiftBoxes.Find(ID);
            }
        }
        public void SaveGiftBox(GiftBox GiftBox)
        {
            using (var context = new AWContext())
            {
                context.GiftBoxes.Add(GiftBox);
                context.SaveChanges();
            }
        }
        public void UpdateGiftBox(GiftBox GiftBox)
        {
            using (var context = new AWContext())
            {
                context.Entry(GiftBox).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteGiftBox(int ID)
        {
            using (var context = new AWContext())
            {

                var GiftBox = context.GiftBoxes.Find(ID);
                context.GiftBoxes.Remove(GiftBox);
                context.SaveChanges();
            }
        }
        public List<GiftBox> GetSelectedProductGiftBoxs(int ItemID)
        {

            using (var context = new AWContext())
            {
                if (ItemID != 0)
                {
                    return context.GiftBoxes.Where(x => x.ItemID == ItemID).ToList();
                }
                else
                {
                    return context.GiftBoxes.ToList();
                }
            }
        }

        public GiftBox GetSelectedProductGiftBoxs(int ItemID, int? GiftBoxID)
        {

            using (var context = new AWContext())
            {
                return context.GiftBoxes.Where(x => x.ItemID == ItemID && x.ID == GiftBoxID).FirstOrDefault();
            }
        }


        #endregion


    }
}
