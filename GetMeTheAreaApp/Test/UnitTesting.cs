using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetMeTheAreaApp.Logic.Domain.Helpers;
using NUnit.Framework;

namespace GetMeTheAreaApp.Test
{
    [TestFixture]
    public class UnitTesting
    {
        [Test]
        public void TestGetCircleAreaUtil()
        {
            // radio
            int radio = 5;
            // Create Instance
            GetCircleAreaUtil _util = new(radio);
            // Test Method
            double res = _util.CalculateArea();
            // Check
            Assert.AreEqual(49.347938640499997, res);
        }

        [Test]
        public void TestGetTriangleAreaUtil()
        {
            // Values
            int baseV = 5;
            int height = 5;
            // Create Instance
            GetTriangleAreaUtil _util = new(baseV, height);
            // Test Method
            double res = _util.CalculateArea();
            // Check
            Assert.AreEqual(25, res);
        }
    }
}

