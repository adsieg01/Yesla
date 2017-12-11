using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesla.Models
{
    public class TripListItem
    {
        
        public int TripID { get; set; }
        public int Price { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
    }
}
