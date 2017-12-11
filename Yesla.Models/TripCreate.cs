using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesla.Models
{
   public class TripCreate
    {
        [Key]
        public int TripID { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public DateTime TripTime { get; set; }

        [Required]
        public string Origin { get; set; }

        [Required]
        public string Destination { get; set; }

        [Required]
        public int Hours { get; set; }

        [Required]
        public int Minutes { get; set; }

        [Required]
        public int Seats { get; set; }

        [Required]
        public int CarID { get; set; }

        [Required]
        public int DriverID { get; set; }
    }
}
