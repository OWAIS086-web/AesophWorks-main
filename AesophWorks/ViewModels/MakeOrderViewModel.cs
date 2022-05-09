using AesophWorks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AesophWorks.ViewModels
{
    public class MakeOrderViewModel
    {
        public List<Item> Items { get; set; }
        public List<Size> Sizes { get; set; }
        public List<CutterButter> CutterButters { get; set; }
        public List<Accent> Accents { get; set; }
        public List<Feet> Feets { get; set; }
        public List<Inlay> Inlays { get; set; }
        public List<WoodType> WoodTypes { get; set; }
        public List<OrderType> OrderTypes { get; set; }
        public List<Handle> Handles { get; set; }
        public List<GiftBox> GiftBoxes { get; set; }
        public Double Total { get; set; }



        //For OrderSaving
        public int Item { get; set; }
        public int GiftBox { get; set; }
        public Double GiftBoxPrice { get; set; }
        public int Handle { get; set; }
        public Double HandPrice { get; set; }
        public int WoodType { get; set; }
        public Double WoodTypePrice { get; set; }
        public int Feet { get; set; }
        public Double FeetPrice { get; set; }
        public int Inlay { get; set; }

        public int Accent { get; set; }

        public Double AccentPrice { get; set; }
        public Double InlayPrice { get; set; }
        public string InlayTextStyle { get; set; }
        public string InlayTextSpecification { get; set; }
        public int Size { get; set; }
        public Double SizePrice { get; set; }
        public int CutterButter { get; set; }
        public Double OrderTypePrice { get; set; }
        public int OrderType { get; set; }
        public Double CutterButterPrice { get; set; }
        public Double GrandTotal { get; set; }



    }



}