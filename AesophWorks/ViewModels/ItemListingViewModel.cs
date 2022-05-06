using AesophWorks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AesophWorks.ViewModels
{
    public class ItemListingViewModel
    {
        public List<Item> Items { get; set; }

        public string SearchTerm { get; set; }
    }

    public class ItemActionViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool JuiceGroove { get; set; }
        public bool FingerGroove { get; set; }
        public string ItemType { get; set; }
        public bool Handles { get; set; }
        public string Font { get; set; }
        public string Customization { get; set; }
        public int Quantity { get; set; }
        public string Shape { get; set; }
        public string TypeOfOrder { get; set; }
        public bool GiftBox { get; set; }
        public List<string> ItemTypes { get; set; }
        public string Hanger { get; set; }
        
    }

  


}