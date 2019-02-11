using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint0AerialVehicle;

namespace Sprint1AerialVehicleUnitTest
{
    [TestClass]
    public class UnitTestToyplane
    {
        ToyPlane toyPlane;

        [TestMethod]
        public void TestToyplaneWindUp()
        {
            //Arrange
            toyPlane = new ToyPlane();

            //Act 
            toyPlane.WindUp();
            string GetWindUpString = toyPlane.getWindUpString();

            //Assert
            Assert.AreEqual(true, toyPlane.isWoundUp);
            Assert.AreEqual($"{toyPlane} is wound up", GetWindUpString);

        }

        [TestMethod]
        public void TestToyplaneUnwind()
        {
            //Arrange
            toyPlane = new ToyPlane();

            //Act
            toyPlane.isWoundUp = true;
            toyPlane.UnWind();
            string GetWindUpString = toyPlane.getWindUpString();

            //Assert
            Assert.AreEqual(false, toyPlane.isWoundUp);
            Assert.AreEqual($"{toyPlane} is not wound up", GetWindUpString);
        }
    }
}
