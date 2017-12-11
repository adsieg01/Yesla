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
        
        bool TripCreate(TripCreate model);
        bool EditTrip();
        int ShowTripByID();
        IEnumerable<TripCreate> GetTrips();


    }
}
