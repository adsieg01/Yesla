using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesla.Models
{
   public class TripBuy
    {
        public int Price { get; set; }

        public DateTime TripTime { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public int Hours { get; set; }

        public int Minutes { get; set; }
    }
}
