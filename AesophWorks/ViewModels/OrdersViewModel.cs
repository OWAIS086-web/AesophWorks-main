using AesophWorks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AesophWorks.ViewModels
{
    public class OrderListingViewModel
    {
        public List<Order> Orders { get; set; }

        public string SearchTerm { get; set; }
    }

    public class OrderActionViewModel
    {
        public int ID { get; set; }
        public string Item { get; set; }
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
        public string Name { get; set; }

    }
}