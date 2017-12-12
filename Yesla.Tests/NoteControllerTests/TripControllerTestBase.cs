using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesla.Contracts;
using Yesla.Services;
using Yesla.Web.Controllers;

namespace Yesla.Tests.NoteControllerTests
{
    

    [TestClass]
    public abstract class TripControllerTestBase
    {

        protected TripController Controller;
        protected FakeTripService TripService;
            


        [TestInitialize]
        public virtual void Arrange()
        {
            TripService = new FakeTripService();

            Controller = new TripController(new Lazy<IYeslaService>(() =>new FakeTripService()));

        }

    }
}
