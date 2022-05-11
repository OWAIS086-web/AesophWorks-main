using AesophWorks.Services;
using AesophWorks.ViewModels;
using System;
using AesophWorks.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AesophWorks.Controllers
{
    public class WorkshopController : Controller
    {
        // GET: Workshop
        public ActionResult Index(string SearchTerm)
        {
            WorkshopListingViewModel model = new WorkshopListingViewModel();
            model.Workshops = WorkshopServices.Instance.GetAllWorkshops(SearchTerm);
            return View(model);
        }

        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            WorkshopActionViewModel model = new WorkshopActionViewModel();
            if (ID != 0)
            {
                var Workshop = WorkshopServices.Instance.GetWorkshop(ID);
                model.ID = Workshop.ID;
                model.Name = Workshop.Name;
                model.Date = Workshop.Date;
                model.Price = Workshop.Price;
                return PartialView("Action", model);

            }
            else
            {
                return View("Action", model);
            }
        }



        [HttpPost]
        public ActionResult Action(WorkshopActionViewModel model)
        {
            if (model.ID != 0) //update record
            {
                var Workshop = WorkshopServices.Instance.GetWorkshop(model.ID);

                Workshop.ID = model.ID;
                Workshop.Name = model.Name;
                Workshop.Date = model.Date;
                Workshop.Price = model.Price;
                WorkshopServices.Instance.UpdateWorkshop(Workshop);

            }
            else
            {
                var Workshop = new Workshop();
                Workshop.ID = model.ID;
                Workshop.Name = model.Name;
                Workshop.Date = model.Date;
                Workshop.Price = model.Price;

                WorkshopServices.Instance.SaveWorkshop(Workshop);
            }
            return RedirectToAction("Index", "Workshop");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            WorkshopActionViewModel model = new WorkshopActionViewModel();
            var Workshop = WorkshopServices.Instance.GetWorkshop(ID);
            model.ID = Workshop.ID;
            model.Name = Workshop.Name;

            return View("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(WorkshopActionViewModel model)
        {

            if (model.ID != 0) //we are trying to delete a record
            {
                var Workshop = WorkshopServices.Instance.GetWorkshop(model.ID);
                WorkshopServices.Instance.DeleteWorkshop(Workshop.ID);
            }
            return RedirectToAction("Index", "Workshop");

        }


        [HttpGet]
        public ActionResult Booking(string SearchTerm)
        {
            WorkshopBookingActionViewModel model = new WorkshopBookingActionViewModel();
            model.Workshops = WorkshopServices.Instance.GetAllWorkshops(SearchTerm);
            return View(model);
        }

        [HttpGet]
        public ActionResult GetAllBookings(string SearchTerm)
        {
            WorkshopBookingActionViewModel model = new WorkshopBookingActionViewModel();
            model.WorkshopBookings = WorkshopServices.Instance.GetAllWorkshopBooking(SearchTerm);
            return View(model);
        }


        [HttpPost]
        public ActionResult Booking(WorkshopBookingActionViewModel model)
        {
            if(model.ID != 0) //Saving Record
            {
                var Booking = WorkshopServices.Instance.GetWorkshopBooking(model.ID);
                var Workshop = WorkshopServices.Instance.GetWorkshop(model.Workshop);
                Booking.ID = model.ID;
                Booking.Name = Workshop.Name;
                Booking.BookedBy = model.BookedBy;
                WorkshopServices.Instance.UpdateWorkshopBooking(Booking);
            }
            else //Update Record
            {
                var WorkshopBooking = new WorkshopBooking();
                WorkshopBooking.ID = model.ID;
                var Workshop = WorkshopServices.Instance.GetWorkshop(model.Workshop);
                WorkshopBooking.Name = Workshop.Name;
                WorkshopBooking.BookedBy = model.BookedBy;
                WorkshopServices.Instance.SaveWorkshopBooking(WorkshopBooking);
            }
            return RedirectToAction("User", "Dashboard");
        }
    }
}