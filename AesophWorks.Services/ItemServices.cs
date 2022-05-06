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
    public class ItemServices
    {
        #region Singleton
        public static ItemServices Instance
        {
            get
            {
                if (instance == null) instance = new ItemServices();
                return instance;
            }
        }
        private static ItemServices instance { get; set; }
        private ItemServices()
        {
        }
        #endregion

        #region ListingIems
        public List<Item> GetAllItems(string SearchTerm)
        {
            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.Items.Where(x => x.Name.Contains(SearchTerm)).ToList();
                }
                else
                {
                    return context.Items.ToList();
                }
            }
        }

     



        #endregion

        #region GetItem
        public Item GetItem(int ID)
        {

            using (var context = new AWContext())
            {

                return context.Items.Find(ID);
            }

        }
        #endregion

        #region UpdateItem
        public void UpdateItem(Item item)
        {
            using (var context = new AWContext())
            {
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        #endregion

        #region SaveItems
        public void SaveItem(Item item)
        {
            using (var context = new AWContext())
            {
                context.Items.Add(item);
                context.SaveChanges();
            }
        }
        #endregion

        #region DeleteItem
        public void DeleteItem(int ID)
        {
            using (var context = new AWContext())
            {

                var cb = context.Items.Find(ID);
                context.Items.Remove(cb);
                context.SaveChanges();
            }
        }
        #endregion
    } 
}
