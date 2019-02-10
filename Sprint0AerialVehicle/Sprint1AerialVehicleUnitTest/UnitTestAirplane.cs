using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint0AerialVehicle;

namespace Sprint1AerialVehicleUnitTest
{
    [TestClass]
    public class UnitTestAirplane
    {
        Airplane airplane;

        [TestMethod]
        public void TestAirplaneAbout()
        {

            //Arrange
            airplane = new Airplane();

            //Act


            //Assert
            Assert.AreEqual($"This {airplane} has a max altitude of {airplane.MaxAltitude} ft.\n It's current altitude is {airplane.CurrentAltitude} ft.\n {airplane.engine} is not started", airplane.About());

        }
    }
}
