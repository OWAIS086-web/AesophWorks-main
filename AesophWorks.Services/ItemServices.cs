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

        //#region ListingIems
        //public List<Item> GetAllCuttingBoard(string SearchTerm)
        //{

        //    using (var context = new AWContext())
        //    {
        //        if (SearchTerm != null)
        //        {
        //            return context.Item.Where(x => x.Name.Contains(SearchTerm)).ToList();
        //        }
        //        else
        //        {
        //            return context.CuttingBoards.ToList();
        //        }
        //    }
        //}

        //public List<ServingTrays> GetAllServingTrays(string SearchTerm)
        //{

        //    using (var context = new AWContext())
        //    {
        //        if (SearchTerm != null)
        //        {
        //            return context.ServingTrays.Where(x => x.Name.Contains(SearchTerm)).ToList();
        //        }
        //        else
        //        {
        //            return context.ServingTrays.ToList();
        //        }
        //    }
        //}

        //public List<ChautericeBoard> GetAllChautericeBoards(string SearchTerm)
        //{

        //    using (var context = new AWContext())
        //    {
        //        if (SearchTerm != null)
        //        {
        //            return context.ChautericeBoards.Where(x => x.Name.Contains(SearchTerm)).ToList();
        //        }
        //        else
        //        {
        //            return context.ChautericeBoards.ToList();
        //        }
        //    }
        //}

        //public List<Ornaments> GetAllOrnaments(string SearchTerm)
        //{

        //    using (var context = new AWContext())
        //    {
        //        if (SearchTerm != null)
        //        {
        //            return context.Ornaments.Where(x => x.Name.Contains(SearchTerm)).ToList();
        //        }
        //        else
        //        {
        //            return context.Ornaments.ToList();
        //        }
        //    }
        //}

        //public List<Coasters> GetAllCoasters(string SearchTerm)
        //{

        //    using (var context = new AWContext())
        //    {
        //        if (SearchTerm != null)
        //        {
        //            return context.Coasters.Where(x => x.Name.Contains(SearchTerm)).ToList();
        //        }
        //        else
        //        {
        //            return context.Coasters.ToList();
        //        }
        //    }
        //}

        //public List<AdirondackChair> GetAllAdirondackChairs(string SearchTerm)
        //{

        //    using (var context = new AWContext())
        //    {
        //        if (SearchTerm != null)
        //        {
        //            return context.AdirondackChairs.Where(x => x.Name.Contains(SearchTerm)).ToList();
        //        }
        //        else
        //        {
        //            return context.AdirondackChairs.ToList();
        //        }
        //    }
        //}


        //public List<CNCEngraving> GetAllCNCEngravings(string SearchTerm)
        //{

        //    using (var context = new AWContext())
        //    {
        //        if (SearchTerm != null)
        //        {
        //            return context.CNCEngravings.Where(x => x.Name.Contains(SearchTerm)).ToList();
        //        }
        //        else
        //        {
        //            return context.CNCEngravings.ToList();
        //        }
        //    }
        //}

        //public List<Knives> GetAllKnives(string SearchTerm)
        //{

        //    using (var context = new AWContext())
        //    {
        //        if (SearchTerm != null)
        //        {
        //            return context.Knives.Where(x => x.Name.Contains(SearchTerm)).ToList();
        //        }
        //        else
        //        {
        //            return context.Knives.ToList();
        //        }
        //    }
        //}


        //public List<WeddingFavor> GetAllWeddingFavors(string SearchTerm)
        //{

        //    using (var context = new AWContext())
        //    {
        //        if (SearchTerm != null)
        //        {
        //            return context.WeddingFavors.Where(x => x.Name.Contains(SearchTerm)).ToList();
        //        }
        //        else
        //        {
        //            return context.WeddingFavors.ToList();
        //        }
        //    }
        //}



        //#endregion

        //#region GetItem
        //public CuttingBoard GetCuttingBoard(int ID)
        //{

        //    using (var context = new AWContext())
        //    {

        //        return context.CuttingBoards.Find(ID);
        //    }

        //}
        //public ServingTrays GetServingTray(int ID)
        //{

        //    using (var context = new AWContext())
        //    {

        //        return context.ServingTrays.Find(ID);
        //    }

        //}
        //public Ornaments GetOrnament(int ID)
        //{

        //    using (var context = new AWContext())
        //    {

        //        return context.Ornaments.Find(ID);
        //    }

        //}
        //public Knives GetKnive(int ID)
        //{

        //    using (var context = new AWContext())
        //    {

        //        return context.Knives.Find(ID);
        //    }

        //}
        //public Coasters GetCoaster(int ID)
        //{

        //    using (var context = new AWContext())
        //    {

        //        return context.Coasters.Find(ID);
        //    }

        //}
        //public CNCEngraving GetCNCEngraving(int ID)
        //{

        //    using (var context = new AWContext())
        //    {

        //        return context.CNCEngravings.Find(ID);
        //    }

        //}
        //public WeddingFavor GetWeddingFavor(int ID)
        //{

        //    using (var context = new AWContext())
        //    {

        //        return context.WeddingFavors.Find(ID);
        //    }

        //}
        //public ChautericeBoard GetChautericeBoard(int ID)
        //{

        //    using (var context = new AWContext())
        //    {

        //        return context.ChautericeBoards.Find(ID);
        //    }

        //}
        //public AdirondackChair GetAdirondackChair(int ID)
        //{

        //    using (var context = new AWContext())
        //    {

        //        return context.AdirondackChairs.Find(ID);
        //    }

        //}


        //#endregion

        //#region UpdateItem
        //public void UpdateItem(CuttingBoard cuttingBoard)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.Entry(cuttingBoard).State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        //public void UpdateItem(ServingTrays ServingTray)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.Entry(ServingTray).State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        //public void UpdateItem(ChautericeBoard ChautericeBoard)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.Entry(ChautericeBoard).State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        //public void UpdateItem(Ornaments Ornament)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.Entry(Ornament).State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        //public void UpdateItem(Knives Knive)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.Entry(Knive).State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        //public void UpdateItem(CNCEngraving CNCEngraving)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.Entry(CNCEngraving).State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        //public void UpdateItem(Coasters Coaster)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.Entry(Coaster).State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        //public void UpdateItem(WeddingFavor WeddingFavor)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.Entry(WeddingFavor).State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        //public void UpdateItem(AdirondackChair AdirondackChair)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.Entry(AdirondackChair).State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}


        //#endregion

        //#region SaveItems
        //public void SaveItem(CuttingBoard cuttingBoard)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.CuttingBoards.Add(cuttingBoard);
        //        context.SaveChanges();
        //    }
        //}
        //public void SaveItem(ServingTrays servingTrays)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.ServingTrays.Add(servingTrays);
        //        context.SaveChanges();
        //    }
        //}

        //public void SaveItem(ChautericeBoard chautericeBoard)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.ChautericeBoards.Add(chautericeBoard);
        //        context.SaveChanges();
        //    }
        //}

        //public void SaveItem(Knives knife)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.Knives.Add(knife);
        //        context.SaveChanges();
        //    }
        //}


        //public void SaveItem(WeddingFavor weddingFavor)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.WeddingFavors.Add(weddingFavor);
        //        context.SaveChanges();
        //    }
        //}


        //public void SaveItem(Ornaments ornaments)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.Ornaments.Add(ornaments);
        //        context.SaveChanges();
        //    }
        //}

        //public void SaveItem(Coasters coaster)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.Coasters.Add(coaster);
        //        context.SaveChanges();
        //    }
        //}

        //public void SaveItem(AdirondackChair chair)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.AdirondackChairs.Add(chair);
        //        context.SaveChanges();
        //    }
        //}

        //public void SaveItem(CNCEngraving cnc)
        //{
        //    using (var context = new AWContext())
        //    {
        //        context.CNCEngravings.Add(cnc);
        //        context.SaveChanges();
        //    }
        //}

        //#endregion

        //#region DeleteItem
        //public void DeleteCuttingBoard(int ID)
        //{
        //    using (var context = new AWContext())
        //    {

        //        var cb = context.CuttingBoards.Find(ID);
        //        context.CuttingBoards.Remove(cb);
        //        context.SaveChanges();
        //    }
        //}
        //public void DeleteChautericeBoard(int ID)
        //{
        //    using (var context = new AWContext())
        //    {

        //        var cb = context.ChautericeBoards.Find(ID);
        //        context.ChautericeBoards.Remove(cb);
        //        context.SaveChanges();
        //    }
        //}
        //public void DeleteServingTray(int ID)
        //{
        //    using (var context = new AWContext())
        //    {

        //        var cb = context.ServingTrays.Find(ID);
        //        context.ServingTrays.Remove(cb);
        //        context.SaveChanges();
        //    }
        //}
        //public void DeleteOrnament(int ID)
        //{
        //    using (var context = new AWContext())
        //    {

        //        var cb = context.Ornaments.Find(ID);
        //        context.Ornaments.Remove(cb);
        //        context.SaveChanges();
        //    }
        //}
        //public void DeleteCNCEngraving(int ID)
        //{
        //    using (var context = new AWContext())
        //    {

        //        var cb = context.CNCEngravings.Find(ID);
        //        context.CNCEngravings.Remove(cb);
        //        context.SaveChanges();
        //    }
        //}
        //public void DeleteKnive(int ID)
        //{
        //    using (var context = new AWContext())
        //    {

        //        var cb = context.Knives.Find(ID);
        //        context.Knives.Remove(cb);
        //        context.SaveChanges();
        //    }
        //}
        //public void DeleteCoaster(int ID)
        //{
        //    using (var context = new AWContext())
        //    {

        //        var cb = context.Coasters.Find(ID);
        //        context.Coasters.Remove(cb);
        //        context.SaveChanges();
        //    }
        //}
        //public void DeleteWeddingFavor(int ID)
        //{
        //    using (var context = new AWContext())
        //    {

        //        var cb = context.WeddingFavors.Find(ID);
        //        context.WeddingFavors.Remove(cb);
        //        context.SaveChanges();
        //    }
        //}
        //public void DeleteAdirondackChair(int ID)
        //{
        //    using (var context = new AWContext())
        //    {

        //        var cb = context.AdirondackChairs.Find(ID);
        //        context.AdirondackChairs.Remove(cb);
        //        context.SaveChanges();
        //    }
        //}

        //#endregion
    }
}
