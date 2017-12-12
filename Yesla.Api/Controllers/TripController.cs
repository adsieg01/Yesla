using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Yesla.Models;
using Yesla.Services;

namespace Yesla.Api.Controllers
{
    [Authorize]
    public class TripController : ApiController
    {

        //GET api/trip
        public IHttpActionResult GetAll()
        {

            var userId = Guid.Parse(User.Identity.GetUserId());
            var tripService = new TripService(userId);
            var trips = tripService.GetTrips();
            return Ok(trips);
        }

        public IHttpActionResult Get(int id)
        {
            var tripService = new TripService(Guid.Parse(User.Identity.GetUserId()));
            var note = tripService.GetTripById(id);
            if (note == null) return NotFound();
            return Ok(note);
        }

        public IHttpActionResult Post(TripCreate model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var tripService = new TripService(Guid.Parse(User.Identity.GetUserId()));
            return Ok(tripService.TripCreate(model));
        }

        public IHttpActionResult Put(TripEdit model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var noteService = new TripService(Guid.Parse(User.Identity.GetUserId()));
            var temp = noteService.GetTripById(model.TripID);

            if (temp == null) return NotFound();

            return Ok(noteService.EditTrip(model));
        }

        public IHttpActionResult Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var noteService = new TripService(Guid.Parse(User.Identity.GetUserId()));
            var temp = noteService.GetTripById(id);

            if (temp == null) return NotFound();

            return Ok(noteService.DeleteTrip(id));

        }


    }
}