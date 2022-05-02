using AesophWorks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AesophWorks.ViewModels
{
    public class ItemListingViewModel
    {
        public List<CuttingBoard> CuttingBoards { get; set; }
        public List<ServingTrays> ServingTrays { get; set; }
        public List<Knives> Knives { get; set; }
        public List<Coasters> Coasters { get; set; }
        public List<CNCEngraving> CNCEngravings { get; set; }
        public List<ChautericeBoard> ChautericeBoards { get; set; }
        public List<Ornaments> Ornaments { get; set; }
        public List<WeddingFavor> WeddingFavors { get; set; }
        public List<AdirondackChair> AdirondackChairs { get; set; }
    }
}