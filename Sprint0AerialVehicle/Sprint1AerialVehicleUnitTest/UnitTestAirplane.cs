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
            string engineStatusAfter = airplane.GetEngineStartedString();

            //Assert
            Assert.AreEqual($"{airplane} is no longer flying", engineStatusBefore);
            Assert.AreEqual($"{airplane} is flying", engineStatusAfter);
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

        [TestMethod]
        public void TestAirplaneFlyUpAndDown()
        {
            //Arrange
            airplane = new Airplane();

            //Act
            int currentAltitudeBefore = airplane.CurrentAltitude;
            airplane.FlyUp();
            int currentAltitudeAfterFlyUp = airplane.CurrentAltitude;
            airplane.FlyDown();
            int currentAltitudeAfterFlyDown = airplane.CurrentAltitude;

            //Assert
            Assert.AreEqual(0, currentAltitudeBefore);
            Assert.AreEqual(1000, currentAltitudeAfterFlyUp);
            Assert.AreEqual(0, currentAltitudeAfterFlyDown);
        }

        [TestMethod]
        public void TestAirplaneFlyUpAndDownHowManyFeet()
        {
            //Arrange
            airplane = new Airplane();

            //Act
            int currentAltitudeBefore = airplane.CurrentAltitude;
            airplane.FlyUp(2000);
            int currentAltitudeAfterFlyUp = airplane.CurrentAltitude;
            airplane.FlyDown(3000);
            int currentAltitiudeAfterFlyDown = airplane.CurrentAltitude;
            airplane.FlyDown(2000);
            int currentAltitudeAfterFlyDownCorrently = airplane.CurrentAltitude;

            //Assert
            Assert.AreEqual(0, currentAltitudeBefore);
            Assert.AreEqual(2000, currentAltitudeAfterFlyUp);
            Assert.AreEqual(2000, currentAltitiudeAfterFlyDown);
            Assert.AreEqual(0, currentAltitudeAfterFlyDownCorrently);
        }

        [TestMethod]
        public void AirplaneTestStartEngine()
        {
            //Arrange
            airplane = new Airplane();

            //Act
            airplane.StartEngine();


            //Assert
            Assert.AreEqual(true, airplane.engine.isStarted);
        }

        [TestMethod]
        public void AirplaneTestStopEngine()
        {
            //Arrange
            airplane = new Airplane();

            //Act
            airplane.StopEngine();


            //Assert
            Assert.AreEqual(false, airplane.engine.isStarted);
        }
    }
}
