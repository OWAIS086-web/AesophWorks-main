using AesophWorks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AesophWorks.ViewModels
{
    public class WorkshopListingViewModel
    {
        public List<Workshop> Workshops { get; set; }
        public string SearchTerm { get; set; }
    }

    public class WorkshopActionViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Double Price { get; set; }
    }

    public class WorkshopLists
    {
        public List<Workshop> Workshops { get; set; }
        public Workshop Workshop { get; set; }
        public int ID { get; set; }
        public string BookedBy { get; set; }
    }

    public class WorkshopBookingActionViewModel
    {
        public string SearchTerm { get; set; }
        public List<Workshop> Workshops { get; set; }
        public int ID { get; set; }
        public string BookedBy { get; set; }
        public int Workshop { get; set; }
        public List<WorkshopLists> WorkshopBookings { get; set; }
    }

}