using AesophWorks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AesophWorks.ViewModels
{
    public class AccentListingViewModel
    {
        public List<Accent> Accents { get; set; }
        public List<MyList> MyLists { get; set; }

        public string SearchTerm { get; set; }
    }
    public class AccentActionViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public List<Item> Items { get; set; }

    }

    public class GiftBoxListingViewModel
    {
        public List<GiftBox> GiftBoxs { get; set; }
        public List<MyList> MyLists { get; set; }

        public string SearchTerm { get; set; }
    }
    public class GiftBoxActionViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public List<Item> Items { get; set; }

    }


    public class HandleListingViewModel
    {
        public List<Handle> Handles { get; set; }
        public List<MyList> MyLists { get; set; }

        public string SearchTerm { get; set; }
    }
    public class HandleActionViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public List<Item> Items { get; set; }

    }



    public class InlayListingViewModel
    {
        public List<Inlay> Inlays { get; set; }
        public List<MyList> MyLists { get; set; }

        public string SearchTerm { get; set; }
    }
    public class InlayActionViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
       
        public List<Item> Items { get; set; }

    }



    public class CutterButterListingViewModel
    {
        public List<CutterButter> CutterButters { get; set; }
        public List<MyList> MyLists { get; set; }

        public string SearchTerm { get; set; }
    }
    public class CutterButterActionViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public List<Item> Items { get; set; }

    }



    public class FeetListingViewModel
    {
        public List<Feet> Feets { get; set; }
        public List<MyList> MyLists { get; set; }

        public string SearchTerm { get; set; }
    }
    public class FeetActionViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public List<Item> Items { get; set; }

    }




    public class SizeListingViewModel
    {
        public List<Size> Sizes { get; set; }
        public List<MyList> MyLists { get; set; }
        public string SearchTerm { get; set; }
    }
    public class SizeActionViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public List<Item> Items { get; set; }

    }

    public class WoodTypeListingViewModel
    {
        public List<WoodType> WoodTypes { get; set; }
        public List<MyList> MyLists { get; set; }
        public string SearchTerm { get; set; }
    }
    public class WoodTypeActionViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public List<Item> Items { get; set; }
    }

    public class MyList
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public Item Item { get; set; }

    }

    public class OrderTypeListingViewModel
    {
        public List<ItemType> OrderTypes { get; set; }
        public List<MyList> MyLists { get; set; }

        public string SearchTerm { get; set; }
    }
    public class OrderTypeActionViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public List<Item> Items { get; set; }

    }


}