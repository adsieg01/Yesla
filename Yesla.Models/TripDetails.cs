using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesla.Models
{
    public class TripDetails
    {
        
        public int Price { get; set; }

        public DateTime TripTime { get; set; }

        public int Seats { get; set; }
   
        public string Origin { get; set; }

        public string Destination { get; set; }

        public int Hours { get; set; }

        public int Minutes { get; set; }

        public string Model { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


    }
}
