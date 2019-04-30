using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint0AerialVehicle;

namespace Sprint1AerialVehicleUnitTest
{
    [TestClass]
    public class UnitTestDrone
    {

        Drone drone;

        [TestMethod]
        public void TestDroneAbout()
        {

            //Arrange
            drone = new Drone();

            //Act


            //Assert
            Assert.AreEqual($"This {drone} has a max altitude of {drone.MaxAltitude} ft.\n It's current altitude is {drone.CurrentAltitude} ft.\n {drone.engine} is not started", drone.About());

        }

        [TestMethod]
        public void TestDroneGetEngineStartedString()
        {
            //Arrange
            drone = new Drone();

            //Act
            string engineStatusBefore = drone.GetEngineStartedString();
            drone.engine.isStarted = true;
            string engineStatusAfter = drone.GetEngineStartedString();

            //Assert
            Assert.AreEqual($"{drone} is no longer flying", engineStatusBefore);
            Assert.AreEqual($"{drone} is flying", engineStatusAfter);
        }

        [TestMethod]
        public void TestDroneTakeOff()
        {
            //Arrange
            drone = new Drone();

            //Act
            string canTakeOffBefore = drone.TakeOff();
            drone.engine.isStarted = true;
            string canTakeOffAfter = drone.TakeOff();

            //Assert

            Assert.AreEqual($"{drone} cannot take off because it's engine is not started", canTakeOffBefore);
            Assert.AreEqual("", canTakeOffAfter);
        }

        [TestMethod]
        public void TestDroneFlyUpAndDown()
        {
            //Arrange
            drone = new Drone();

            //Act
            int currentAltitudeBefore = drone.CurrentAltitude;
            drone.FlyUp();
            int currentAltitudeAfterFlyUp = drone.CurrentAltitude;
            drone.FlyDown();
            int currentAltitudeAfterFlyDown = drone.CurrentAltitude;

            //Assert
            Assert.AreEqual(0, currentAltitudeBefore);
            Assert.AreEqual(100, currentAltitudeAfterFlyUp);
            Assert.AreEqual(0, currentAltitudeAfterFlyDown);
        }

        [TestMethod]
        public void TestDroneFlyUpAndDownHowManyFeet()
        {
            //Arrange
            drone = new Drone();

            //Act
            int currentAltitudeBefore = drone.CurrentAltitude;
            drone.FlyUp(200);
            int currentAltitudeAfterFlyUp = drone.CurrentAltitude;
            drone.FlyDown(300);
            int currentAltitiudeAfterFlyDown = drone.CurrentAltitude;
            drone.FlyDown(200);
            int currentAltitudeAfterFlyDownCorrently = drone.CurrentAltitude;

            //Assert
            Assert.AreEqual(0, currentAltitudeBefore);
            Assert.AreEqual(200, currentAltitudeAfterFlyUp);
            Assert.AreEqual(200, currentAltitiudeAfterFlyDown);
            Assert.AreEqual(0, currentAltitudeAfterFlyDownCorrently);
        }

        [TestMethod]
        public void DroneTestStartEngine()
        {
            //Arrange
            drone = new Drone();

            //Act
            drone.StartEngine();


            //Assert
            Assert.AreEqual(true, drone.engine.isStarted);
        }

        [TestMethod]
        public void DroneTestStopEngine()
        {
            //Arrange
            drone = new Drone();

            //Act
            drone.engine.isStarted = true;
            drone.StopEngine();


            //Assert
            Assert.AreEqual(false, drone.engine.isStarted);
        }
    }
}
