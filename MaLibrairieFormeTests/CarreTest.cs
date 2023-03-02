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
    public class CarreTests
    {
        [TestMethod()]
        public void CoordonneeEstDansTest()
        {
            Coordonnees coord = new(5, 3);
            Carre carre = new(3, 2, 6);

            Assert.IsTrue(carre.CoordonneeEstDans(coord));
        }

        [TestMethod()]
        public void CoordonneeEstDansTest1()
        {
            Coordonnees coord = new(8, 4);
            Carre carre = new(7, 5, 4);

            Assert.IsFalse(carre.CoordonneeEstDans(coord));
        }
    }
}

