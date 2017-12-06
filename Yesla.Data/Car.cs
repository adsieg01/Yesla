using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesla.Data
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int Seats { get; set; }

        public bool InUse { get; set; }
    }
}
