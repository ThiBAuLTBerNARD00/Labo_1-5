using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaLibrairieForme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme.Tests
{
    [TestClass()]
    public class CoordonneesTests
    {
        [TestMethod()]
        public void CoordonneesTest()
        {
            // Arrange
            int expectedX = 10;
            int expectedY = 20;

            // Act
            Coordonnees coord = new Coordonnees(expectedX, expectedY);

            // Assert
            Assert.AreEqual(expectedX, coord.x);
            Assert.AreEqual(expectedY, coord.y);

            
        }

        [TestMethod()]
        public void CoordonneesTest1()
        {

            Assert.Fail();
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }
    }
}