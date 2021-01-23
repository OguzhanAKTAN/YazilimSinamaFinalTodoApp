using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace YazilimSinamaFinal
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public void TestPersonelID()
        {
            int result;
            result = DataBaseQueries.GetPersonelID("Mert Bereket", 0);
            Assert.AreEqual(2, result);
        }

    }
}
