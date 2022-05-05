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
        public string SearchTerm { get; set; }
        public List<Item> Items { get; set; }
    }
    public class AccentActionViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }



    public class InlayListingViewModel
    {
        public List<Inlay> Inlays { get; set; }
        public string SearchTerm { get; set; }
        public List<Item> Items { get; set; }
    }
    public class InlayActionViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string InlaySpecs { get; set; }
        public string InlayTextStyle { get; set; }
    }



    public class CutterButterListingViewModel
    {
        public List<CutterButter> CutterButters { get; set; }
        public string SearchTerm { get; set; }
        public List<Item> Items { get; set; }
    }
    public class CutterButterActionViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }



    public class FeetListingViewModel
    {
        public List<Feet> Feets { get; set; }
        public string SearchTerm { get; set; }
        public List<Item> Items { get; set; }
    }
    public class FeetActionViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }




    public class SizeListingViewModel
    {
        public List<Size> Sizes { get; set; }
        public string SearchTerm { get; set; }
        public List<Item> Items { get; set; }
    }
    public class SizeActionViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }

    public class WoodTypeListingViewModel
    {
        public List<WoodType> WoodTypes { get; set; }
        public string SearchTerm { get; set; }
        public List<Item> Items { get; set; }
    }
    public class WoodTypeActionViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }




    public class OrderTypeListingViewModel
    {
        public List<OrderType> OrderTypes { get; set; }
        public string SearchTerm { get; set; }
        public List<Item> Items { get; set; }
    }
    public class OrderTypeActionViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }


}