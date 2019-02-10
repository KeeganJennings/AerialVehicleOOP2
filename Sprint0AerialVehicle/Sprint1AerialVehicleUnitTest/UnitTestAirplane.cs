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

        [TestMethod]
        public void TestAirplaneGetEngineStartedString()
        {
            //Arrange
            airplane = new Airplane();

            //Act
            string engineStatusBefore = airplane.GetEngineStartedString();
            airplane.engine.isStarted = true;
            string engineStatureAfter = airplane.GetEngineStartedString();

            //Assert
            Assert.AreEqual($"{airplane} is no longer flying", engineStatusBefore);
            Assert.AreEqual($"{airplane} is flying", engineStatureAfter);
        }

        [TestMethod]
        public void TestAirplaneTakeOff()
        {
            //Arrange
            airplane = new Airplane();

            //Act
            string canTakeOffBefore = airplane.TakeOff();
            airplane.engine.isStarted = true;
            string canTakeOffAfter = airplane.TakeOff();

            //Assert

            Assert.AreEqual($"{airplane} cannot take off because it's engine is not started", canTakeOffBefore);
            Assert.AreEqual("", canTakeOffAfter);
        }
    }
}
