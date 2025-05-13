using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4._1
{
    [TestClass]
    public class Zadanie4Test
    {
        [TestMethod]
        public void IndexOf_ElementExists_ReturnIndex()
        {
            var z = new Zadanie4();
            Assert.AreEqual(1, z.IndexOf(new[] { 5, 10, 15 }, 10));
        }

        [TestMethod]
        public void IndexOf_ElementNotExists_ReturnsMinusOne()
        {
            var z = new Zadanie4();
            Assert.AreEqual(-1, z.IndexOf(new[] { 5, 10, 15 }, 7));
        }

    }
}
