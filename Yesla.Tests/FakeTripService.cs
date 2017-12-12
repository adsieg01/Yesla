using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesla.Contracts;
using Yesla.Models;

namespace Yesla.Tests
{
   public class FakeTripService : IYeslaService
    {
        

        public int CreateTripCallCount { get; private set; }
        public bool CreateTripReturnValue { private get; set; } = true;


        public IEnumerable<TripListItem> GetTrips()
        {
            throw new NotImplementedException();
        }

        public TripDetail GetTripById(int tripId)
        {
            throw new NotImplementedException();
        }

        public bool EditTrip(TripEdit model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTrip(int tripId)
        {
            throw new NotImplementedException();
        }

        public bool TripCreate(TripCreate model)
        {
            CreateTripCallCount++;

            return CreateTripReturnValue;
        }
    }
}
