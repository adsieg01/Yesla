using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesla.Models
{
    class TripModel
    {
        public int TripID { get; set; }

        public int Price { get; set; }

        public DateTime TripTime { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public int Hours { get; set; }

        public int Minutes { get; set; }

        public int Seats { get; set; }

        public int CarID { get; set; }

        public int DriverID { get; set; }
    }
}
