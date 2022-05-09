using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AesophWorks.Entities
{
    public class Order:BaseEntity
    {
        public string Item { get; set; }
        public string GiftBox { get; set; }
        public Double GiftBoxPrice { get; set; }
        public string Handle { get; set; }
        public Double HandPrice { get; set; }
        public string WoodType { get; set; }
        public Double WoodTypePrice { get; set; }
        public string Feet { get; set; }
        public Double FeetPrice { get; set; }
        public string Inlay { get; set; }
        public Double InlayPrice { get; set; }
        public string InlayTextStyle { get; set; }
        public string InlayTextSpecification { get; set; }
        public string Size { get; set; }
        public Double SizePrice { get; set; }
        public string CutterButter { get; set; }
        public Double CutterButterPrice { get; set; }

        public string OrderType { get; set; }
        public Double OrderTypePrice { get; set; }
        public string Accent { get; set; }
        public Double AccentPrice { get; set; }

        public Double Total { get; set; }
    }
}
