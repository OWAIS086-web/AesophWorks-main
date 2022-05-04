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

    public class CuttingBoardListingViewModel
    {
        public string SearchTerm { get; set; }
        public List<CuttingBoard> CuttingBoards { get; set; }
    }

    public class CuttingBoardActionViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool JuiceGroove { get; set; }
        public string TypeOfCuttingBoard { get; set; }
        public bool FingerGroove { get; set; }
    }

    public class ServingTrayListingViewModel
    {
        public string SearchTerm { get; set; }
        public List<ServingTrays> ServingTrays { get; set; }
    }

    public class ServingTrayActionViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string TypeOfServingTrays { get; set; }
        public string Type { get; set; }
        public bool Handles { get; set; }
    }

    public class ChautericeBoardListingViewModel
    {
        public string SearchTerm { get; set; }
        public List<ChautericeBoard> ChautericeBoards { get; set; }
    }

    public class ChautericeBoardActionViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string TypeOfChautericeBoard { get; set; }
        public string Type { get; set; }
        public bool Handles { get; set; }
    }

    public class CoasterListingViewModel
    {
        public string SearchTerm { get; set; }
        public List<Coasters> Coasters { get; set; }
    }

    public class CoasterActionViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Shape { get; set; }
        public string Font { get; set; }
        public string  Customization { get; set; }
    }
}