using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesla.Models
{
    public class OneTimePurchaseViewModel
    {
        [Key]
        public string StripePublishableKey { get; set; }
    }
}
