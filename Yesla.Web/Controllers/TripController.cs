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
    {   //Create Trips
        private TripService TripCreate()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var svc = new TripService(userId);

            return svc;
        }
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

            if (!TripCreate().TripCreate(model))
            {
                ModelState.AddModelError("", "Unable to create ticket");
                return View(model);
            }

            TempData["SaveResult"] = "Your ticket was created";

            return RedirectToAction("Index");

        }

       




        // GET: Trip
        //public ActionResult Index()
        //{
        //    var model = new TripListItem[0];
        //    return View(model);


        //}

        //public ActionResult Details(int id)
        //{
        //    var svc = CreateTripService();
        //    var model = svc.GetTripById(id);

        //    return View(model);
        //}
    }
}