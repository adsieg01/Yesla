using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yesla.Web.Models;

namespace Yesla.Web.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationUserManager _userManager;

        // GET: Admin
        public ActionResult Index()
        {
            var _UserDTOAsIPagedList =
                  new ExpandedUser
                  (
                      );

            return View(_UserDTOAsIPagedList);
        }

        //Utility
        #region public ApplicationUserManager UserManager
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ??
                    HttpContext.GetOwinContext()
                    .GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        #endregion
    }
}