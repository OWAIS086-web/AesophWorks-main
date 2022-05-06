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


    }
}
