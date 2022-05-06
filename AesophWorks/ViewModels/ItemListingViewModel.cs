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
        public string ItemType { get; set; }
        public List<string> ItemTypes { get; set; }
        
    }

  


}