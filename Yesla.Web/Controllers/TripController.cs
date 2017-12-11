using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yesla.Data;
using Yesla.Models;
using Yesla.Services;

namespace Yesla.Web.Controllers
{
    [Authorize]
    public class TripController : Controller
    {   
        private Guid _userId;

        //GET: Trip
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var svc = new TripService(userId);
            var model = svc.GetTrips();
            return View(model);
        }

        public ActionResult Create()
        {
            var model = new TripCreate();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TripCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            if (!TripCreateService().TripCreate(model))
            {
                ModelState.AddModelError("", "Unable to create ticket");
                return View(model);
            }

            TempData["SaveResult"] = "Your ticket was created";

            return RedirectToAction("Index");

        }

        // Trip Details

        public ActionResult Details(int id)
        {
            var svc = TripCreateService();
            var model = svc.GetTripById(id);

            return View(model);
        }

        // Edit Trip

        public ActionResult Edit(int id)
        {
            var service = TripCreateService();
            var detail = service.GetTripById(id);
            var model =
                new TripEdit
                {
                    TripID = detail.TripID,
                    Price = detail.Price,
                    TripTime = detail.TripTime,
                    Origin = detail.Origin,
                    Destination = detail.Destination,
                    Hours = detail.Hours,
                    Minutes = detail.Minutes,
                    Seats = detail.Seats,
                    CarID = detail.CarID,
                    DriverID = detail.DriverID
                };

            return View(model);
        }

        //Edit Model

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TripEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.TripID != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = TripCreateService();

            if (service.EditTrip(model))
            {
                TempData["SaveResult"] = "Your note was updated";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your note could not be updated.");
            return View(model);
        }

        //Delete Trips

        public ActionResult Delete(int id)
        {
            var svc = TripCreateService();
            var model = svc.GetTripById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = TripCreateService();
    
            service.DeleteTrip(id);

            TempData["SaveResult"] = "Your trip was deleted!";

            return RedirectToAction("Index");
        }

        //Create Trips
        private TripService TripCreateService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var svc = new TripService(userId);

            return svc;
        }
    }
}