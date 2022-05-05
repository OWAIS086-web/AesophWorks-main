using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AesophWorks.Entities
{
    public class Item:BaseEntity
    {
        public bool JuiceGroove { get; set; }
        public string ItemType { get; set; }
        public string Type { get; set; }
        public bool FingerGroove { get; set; }
        public bool Handles { get; set; }
        public string Font { get; set; }
        public string Customization { get; set; }
        public int Quantity { get; set; }
        public string Shape { get; set; }
        public string TypeOfOrder { get; set; }
        public bool GiftBox { get; set; }
        public string Hanger { get; set; }
    }
}
