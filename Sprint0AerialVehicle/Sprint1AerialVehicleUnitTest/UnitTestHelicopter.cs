using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint0AerialVehicle;

namespace Sprint1AerialVehicleUnitTest
{
    [TestClass]
    public class UnitTestHelicopter
    {
        Helicopter helicopter;

        [TestMethod]
        public void TestHelicopterAbout()
        {

            //Arrange
            helicopter = new Helicopter();

            //Act


            //Assert
            Assert.AreEqual($"This {helicopter} has a max altitude of {helicopter.MaxAltitude} ft.\n It's current altitude is {helicopter.CurrentAltitude} ft.\n {helicopter.engine} is not started", helicopter.About());

        }

        [TestMethod]
        public void TestHelicopterGetEngineStartedString()
        {
            //Arrange
            helicopter = new Helicopter();

            //Act
            string engineStatusBefore = helicopter.GetEngineStartedString();
            helicopter.engine.isStarted = true;
            string engineStatusAfter = helicopter.GetEngineStartedString();

            //Assert
            Assert.AreEqual($"{helicopter} is no longer flying", engineStatusBefore);
            Assert.AreEqual($"{helicopter} is flying", engineStatusAfter);
        }

        [TestMethod]
        public void TestHelicopterTakeOff()
        {
            //Arrange
            helicopter = new Helicopter();

            //Act
            string canTakeOffBefore = helicopter.TakeOff();
            helicopter.engine.isStarted = true;
            string canTakeOffAfter = helicopter.TakeOff();

            //Assert

            Assert.AreEqual($"{helicopter} cannot take off because it's engine is not started", canTakeOffBefore);
            Assert.AreEqual("", canTakeOffAfter);
        }

        [TestMethod]
        public void TestHelicopterFlyUpAndDown()
        {
            //Arrange
            helicopter = new Helicopter();

            //Act
            int currentAltitudeBefore = helicopter.CurrentAltitude;
            helicopter.FlyUp();
            int currentAltitudeAfterFlyUp = helicopter.CurrentAltitude;
            helicopter.FlyDown();
            int currentAltitudeAfterFlyDown = helicopter.CurrentAltitude;

            //Assert
            Assert.AreEqual(0, currentAltitudeBefore);
            Assert.AreEqual(1000, currentAltitudeAfterFlyUp);
            Assert.AreEqual(0, currentAltitudeAfterFlyDown);
        }

        [TestMethod]
        public void TestHelicopterFlyUpAndDownHowManyFeet()
        {
            //Arrange
            helicopter = new Helicopter();

            //Act
            int currentAltitudeBefore = helicopter.CurrentAltitude;
            helicopter.FlyUp(2000);
            int currentAltitudeAfterFlyUp = helicopter.CurrentAltitude;
            helicopter.FlyDown(3000);
            int currentAltitiudeAfterFlyDown = helicopter.CurrentAltitude;
            helicopter.FlyDown(2000);
            int currentAltitudeAfterFlyDownCorrently = helicopter.CurrentAltitude;

            //Assert
            Assert.AreEqual(0, currentAltitudeBefore);
            Assert.AreEqual(2000, currentAltitudeAfterFlyUp);
            Assert.AreEqual(2000, currentAltitiudeAfterFlyDown);
            Assert.AreEqual(0, currentAltitudeAfterFlyDownCorrently);
        }

        [TestMethod]
        public void HelicopterTestStartEngine()
        {
            //Arrange
            helicopter = new Helicopter();

            //Act
            helicopter.StartEngine();


            //Assert
            Assert.AreEqual(true, helicopter.engine.isStarted);
        }

        [TestMethod]
        public void HelicopterTestStopEngine()
        {
            //Arrange
            helicopter = new Helicopter();

            //Act
            helicopter.engine.isStarted = true;
            helicopter.StopEngine();


            //Assert
            Assert.AreEqual(false, helicopter.engine.isStarted);
        }
    }
}

