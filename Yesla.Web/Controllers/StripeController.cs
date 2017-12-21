using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stripe;
using Yesla.Web.Models;
using System.Diagnostics;

namespace Yesla.Web.Controllers
{
    [Authorize]
    public class StripeController : Controller
    {
        // embedded form
        public ActionResult Index()
        {
            var stripePublishKey = ConfigurationManager.AppSettings["pk_test_PVMsGrYmkBJ6fTELDJ1zyck7"];
            ViewBag.StripePublishKey = stripePublishKey;
            return View();
        }
    }
}