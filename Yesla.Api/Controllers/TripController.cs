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
            return Ok();
        }

        public IHttpActionResult Put(TripEdit note)
        {
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }

       
    }
}