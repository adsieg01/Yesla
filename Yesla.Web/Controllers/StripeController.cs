using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stripe;
using Yesla.Web.Models;
using System.Diagnostics;
using Yesla.Models;

namespace Yesla.Web.Controllers
{
    [Authorize]
    public class StripeController : Controller
    {
        // GET: OneTimePurchase
        public ActionResult Index()
        {
            string stripePublishableKey = ConfigurationManager.AppSettings["stripePublishableKey"];
            var model = new OneTimePurchaseViewModel { StripePublishableKey = stripePublishableKey };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult Charge(ChargeViewModel chargeViewModel)
        {
            StripeConfiguration.SetApiKey("sk_test_G7sjp9f5VyK5ogExpiwfo8ZO");
            Debug.WriteLine(chargeViewModel.StripeEmail);
            Debug.WriteLine(chargeViewModel.StripeToken);

            var token = chargeViewModel.StripeToken; // Using ASP.NET MVC

            var charges = new StripeChargeService();
            var charge = charges.Create(new StripeChargeCreateOptions
            {
                Amount = 6500,
                Currency = "usd",
                Description = "Credit Card",
                SourceTokenOrExistingSourceId = token
            });

            return RedirectToAction("Confirmation");
        }

        public ActionResult Confirmation()
        {
            return View();
        }
    }
}
