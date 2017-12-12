using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Yesla.Models;

namespace Yesla.Tests.NoteControllerTests
{
    [TestClass]
    public class CreateTrip : TripControllerTestBase
    {
        [TestMethod]
        public void Should_Redirect_Return_Result()
        {
            //Act
            var result = Controller.Create(new TripCreate());

            //Assert - want to make sure that this thing is a redirect to route result
            Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));
        }

        [TestMethod]
        public void ShouldCallCreateOnce()
        {
            var result = Controller.Create(new TripCreate());

            Assert.AreEqual(1, TripService.CreateTripCallCount); 
        }
    }
}
