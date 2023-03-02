using MaLibrairieForme;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieFormeTests
{
    [TestClass()]
    public class CercleTests
    {
        [TestMethod()]
        public void CoordonneeEstDansTest()
        {
            Coordonnees coord = new(5, 4);
            Cercle cercle = new(4, 5, 2);

            Assert.IsTrue(cercle.CoordonneeEstDans(coord));
        }

        [TestMethod()]
        public void CoordonneeEstDansTest1()
        {
            Coordonnees coord = new(4, 8);
            Cercle cercle = new(7, 5, 4);

            Assert.IsFalse(cercle.CoordonneeEstDans(coord));
        }
    }
}
