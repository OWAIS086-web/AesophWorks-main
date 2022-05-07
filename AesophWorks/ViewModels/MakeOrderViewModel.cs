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
        public List<Feet> Feets { get; set; }
        public List<Inlay> Inlays { get; set; }
        public List<WoodType> WoodTypes { get; set; }
    }
}