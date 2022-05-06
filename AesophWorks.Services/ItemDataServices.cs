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

        #endregion


    }
}
