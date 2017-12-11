using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesla.Contracts;
using Yesla.Data;
using Yesla.Models;

namespace Yesla.Services
{
    public class TripService : IYeslaService
    {

        private readonly Guid _userId;
        public TripService(Guid userId)
        {
            _userId = userId;
        }


        // Get Trips
        private Trip GetNoteFromDatabase(ApplicationDbContext context, int tripID)
        {
            return
                context
                    .Trips
                   .SingleOrDefault(e => e.TripID == tripID);
        }

        public IEnumerable<TripListItem> GetTrips()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return
                    ctx
                        .Trips
                        .Select(
                        e =>
                            new TripListItem
                            {
                                TripID = e.TripID,
                                Destination = e.Destination,
                                Price = e.Price,
                                Origin = e.Origin

                            })
                    .ToArray();

            }

        }

        public TripDetail GetTripById(int tripID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Trips
                        .Single(e => e.TripID == tripID);

                return
                    new TripDetail
                    {
                        TripID = entity.TripID,
                        Price = entity.Price,
                        TripTime = entity.TripTime,
                        Origin = entity.Origin,
                        Destination = entity.Destination,
                        Hours = entity.Hours,
                        Minutes = entity.Minutes,
                        Seats = entity.Seats,
                        CarID = entity.CarID,
                        DriverID = entity.DriverID


                    };
            }
        }

        public bool EditTrip(TripEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Trips
                        .Single(e => e.TripID == model.TripID);


                entity.Price = model.Price;
                entity.TripTime = model.TripTime;
                entity.Origin = model.Origin;
                entity.Destination = model.Destination;
                entity.Hours = model.Hours;
                entity.Minutes = model.Minutes;
                entity.Seats = model.Seats;
                entity.CarID = model.CarID;
                entity.DriverID = model.DriverID;

                return ctx.SaveChanges() == 1;
            }
        } 

             
        

        public bool DeleteTrip(int tripID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Trips
                        .Single(e => e.TripID == tripID);

                ctx.Trips.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }

        IEnumerable<TripCreate> IYeslaService.GetTrips()
        {
            throw new NotImplementedException();
        }

        //Create the Trip Ticket
        public bool TripCreate(TripCreate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    new Trip
                    {

                        Price = model.Price,
                        TripTime = model.TripTime,
                        Origin = model.Origin,
                        Destination = model.Destination,
                        Hours = model.Hours,
                        Minutes = model.Minutes,
                        Seats = model.Seats,
                        CarID = model.CarID,
                        DriverID = model.DriverID
                    };

                ctx.Trips.Add(entity);

                return ctx.SaveChanges() == 1;
            }
        }

        public bool EditTrip()
        {
            throw new NotImplementedException();
        }

        public int ShowTripByID()
        {
            throw new NotImplementedException();
        }

    }
} 


