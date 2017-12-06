using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesla.Data
{
    public class Trip
    {
        [Key]
        public int TripID { get; set; }

        public int CustomerID { get; set; }

        [Required]
        public int DriverID { get; set; }

        [Required]
        public int CarID { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public DateTime TripTime { get; set; }

        [Required]
        public int Seats { get; set; }

        [Required]
        public string Origin { get; set; }

        [Required]
        public string Destination { get; set; }

        public int Hours { get; set; }

        public int Minutes { get; set; }




    }
}
