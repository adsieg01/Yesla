using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesla.Models;

namespace Yesla.Contracts
{
    public interface IYeslaService
    {
       IEnumerable<TripListItem> GetTrips();
       bool TripCreate(TripCreate model);
       bool EditTrip(TripEdit model);
       TripDetail GetTripByID(int tripID);
        bool DeleteTrip(int tripID);


    }
}
