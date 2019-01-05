using NUnit.Framework;
using NUnitPrac2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitPrac2.Tests
{
    [TestFixture]
    public class MagicianTest
    {
        [Test]
        public void DoMagic_Testing()
        {
            //Arrange
            int expectedResult = 10;
            String data = "ABC";

            //Act
            Magician obj = new Magician();
            var r = obj.DoMagic(data);

            Assert.AreEqual(r, expectedResult);
        }

        [TestCase("ABC",10)]
        [TestCase("XYZ", 20)]
        [TestCase("X", 30)]
        [TestCase("", 30)]
        public void DoMagic_Testing(String data, int expectedResult)
        {
            //Arrange
            //int expectedResult = 10;

            //Act
            Magician obj = new Magician();
            var r = obj.DoMagic(data);

            Assert.AreEqual(r, expectedResult);
        }

    }
}
