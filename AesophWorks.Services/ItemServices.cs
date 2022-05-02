using AesophWorks.Database;
using AesophWorks.Entities;
using System;
using System.Collections.Generic;
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

        


        public void SaveItem(CuttingBoard cuttingBoard)
        {
            using (var context = new AWContext())
            {
                context.CuttingBoards.Add(cuttingBoard);
                context.SaveChanges();
            }
        }

        public void SaveItem(ServingTrays servingTrays)
        {
            using (var context = new AWContext())
            {
                context.ServingTrays.Add(servingTrays);
                context.SaveChanges();
            }
        }

        public void SaveItem(ChautericeBoard chautericeBoard)
        {
            using (var context = new AWContext())
            {
                context.ChautericeBoards.Add(chautericeBoard);
                context.SaveChanges();
            }
        }

        public void SaveItem(Knives knife)
        {
            using (var context = new AWContext())
            {
                context.Knives.Add(knife);
                context.SaveChanges();
            }
        }


        public void SaveItem(WeddingFavor weddingFavor)
        {
            using (var context = new AWContext())
            {
                context.WeddingFavors.Add(weddingFavor);
                context.SaveChanges();
            }
        }


        public void SaveItem(Ornaments ornaments)
        {
            using (var context = new AWContext())
            {
                context.Ornaments.Add(ornaments);
                context.SaveChanges();
            }
        }

        public void SaveItem(Coasters coaster)
        {
            using (var context = new AWContext())
            {
                context.Coasters.Add(coaster);
                context.SaveChanges();
            }
        }

        public void SaveItem(AdirondackChair chair)
        {
            using (var context = new AWContext())
            {
                context.AdirondackChairs.Add(chair);
                context.SaveChanges();
            }
        }

        public void SaveItem(CNCEngraving cnc)
        {
            using (var context = new AWContext())
            {
                context.CNCEngravings.Add(cnc);
                context.SaveChanges();
            }
        }
    }
}
