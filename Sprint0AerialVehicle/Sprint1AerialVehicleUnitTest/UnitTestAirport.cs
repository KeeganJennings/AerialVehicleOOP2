using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint0AerialVehicle;

namespace Sprint1AerialVehicleUnitTest
{
    [TestClass]
    public class UnitTestAirport
    {
        Airport airport;

        [TestMethod]
        public void TestAirportConstructorOnlyString()
        {
            //Arrange
            string code = "1234";
            airport = new Airport(code);

            //Act

            //Assert
            Assert.AreEqual(code, airport.AirportCode);
        }

        [TestMethod]
        public void TestAirportConstructorMaxVehicles()
        {
            //Arrange
            string code = "1234";
            int maxVehicles = 42;
            airport = new Airport(code, maxVehicles);

            //Act

            //Assert
            Assert.AreEqual(code, airport.AirportCode);
            Assert.AreEqual(maxVehicles, airport.maxVehicles);
        }

        [TestMethod]
        public void LandAndTakeOffSingularVehicle()
        {
            //Arrange
            string landingString;
            string takeOffString;
            int beforeLand;
            int afterLand;
            int afterTakeOff;
            airport = new Airport("1234");
            Airplane airplane = new Airplane();

            //Act
            airplane.StartEngine();
            airplane.IsFlying = true;
            airplane.FlyUp();

            beforeLand = airport.Vehicles.Count;
            landingString = airport.Land(airplane);
            afterLand = airport.Vehicles.Count;
            takeOffString = airport.TakeOff(airplane);
            afterTakeOff = airport.Vehicles.Count;

            //Assert
            Assert.AreEqual($"Landed {airplane.GetType()} ", landingString);
            Assert.AreEqual($"{airplane.GetType()} has taken off!", takeOffString);
            Assert.AreEqual(0, beforeLand);
            Assert.AreEqual(1, afterLand);
            Assert.AreEqual(0, afterTakeOff);
        }

        [TestMethod]
        public void TestMultipleVehiclesInAirport()
        {
            //Arrange
            int afterLand;
            int afterTakeoff;
            string allLanded;
            string allTakeOff;
            List<AerialVehicle> vehiclesToLand = new List<AerialVehicle>();
            airport = new Airport("1234");
            Airplane airplane = new Airplane();
            Drone drone = new Drone();
            Helicopter helicopter = new Helicopter();

            //Act
            airplane.CurrentAltitude = 1000;
            drone.CurrentAltitude = 100;
            helicopter.CurrentAltitude = 1000;

            vehiclesToLand.Add(airplane);
            vehiclesToLand.Add(drone);
            vehiclesToLand.Add(helicopter);

            allLanded = airport.Land(vehiclesToLand);
            afterLand = airport.Vehicles.Count;
            allTakeOff = airport.AllTakeOff();
            afterTakeoff = airport.Vehicles.Count;

            //Assert
            Assert.AreEqual(3, afterLand);
            Assert.AreEqual(0, afterTakeoff);
            Assert.AreEqual("Sprint0AerialVehicle.Airplane Sprint0AerialVehicle.Drone Sprint0AerialVehicle.Helicopter ", allLanded);
            Assert.AreEqual("All took off", allTakeOff);
        }
    }
}

