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
        public List<Item> GetAllCuttingBoard(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.Items.Where(x => x.Name.Contains(SearchTerm) && x.ItemType == "Cutting Board").ToList();
                }
                else
                {
                    return context.Items.Where(x => x.ItemType == "Cutting Board").ToList();
                }
            }
        }

        public List<Item> GetAllServingTrays(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.Items.Where(x => x.Name.Contains(SearchTerm) && x.ItemType == "Serving Trays").ToList();
                }
                else
                {
                    return context.Items.Where(x => x.ItemType == "Serving Trays").ToList();
                }
            }
        }

        public List<Item> GetAllChautericeBoards(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.Items.Where(x => x.Name.Contains(SearchTerm) && x.ItemType == "Chauterice Boards").ToList();
                }
                else
                {
                    return context.Items.Where(x => x.ItemType == "Chauterice Boards").ToList();
                }
            }
        }

        public List<Item> GetAllOrnaments(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.Items.Where(x => x.Name.Contains(SearchTerm) && x.ItemType == "Ornaments").ToList();
                }
                else
                {
                    return context.Items.Where(x => x.ItemType == "Ornaments").ToList();
                }
            }
        }

        public List<Item> GetAllCoasters(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.Items.Where(x => x.Name.Contains(SearchTerm) && x.ItemType == "Coasters").ToList();
                }
                else
                {
                    return context.Items.Where(x => x.ItemType == "Coasters").ToList();
                }
            }
        }

        public List<Item> GetAllAdirondackChairs(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.Items.Where(x => x.Name.Contains(SearchTerm) && x.ItemType == "Adirondack Chairs").ToList();
                }
                else
                {
                    return context.Items.Where(x => x.ItemType == "Adirondack Chairs").ToList();
                }
            }
        }


        public List<Item> GetAllCNCEngravings(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.Items.Where(x => x.Name.Contains(SearchTerm) && x.ItemType == "CNC Engraving").ToList();
                }
                else
                {
                    return context.Items.Where(x => x.ItemType == "CNC Engraving").ToList();
                }
            }
        }

        public List<Item> GetAllKnives(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.Items.Where(x => x.Name.Contains(SearchTerm) && x.ItemType == "Knives").ToList();
                }
                else
                {
                    return context.Items.Where(x => x.ItemType == "Knives").ToList();
                }
            }
        }


        public List<Item> GetAllWeddingFavors(string SearchTerm)
        {

            using (var context = new AWContext())
            {
                if (SearchTerm != null)
                {
                    return context.Items.Where(x => x.Name.Contains(SearchTerm) && x.ItemType == "Wedding Favors").ToList();
                }
                else
                {
                    return context.Items.Where(x => x.ItemType == "Wedding Favors").ToList();
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
