using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KlochenokVA.Sprint1.Task3.V13.Lib;

namespace Tyuiu.KlochenokVA.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double res1 = ds.MultiplyOfDigits(234);
            Assert.AreEqual(24, res1);

            double res2 = ds.MultiplyOfDigits(999);
            Assert.AreEqual(729, res2);

            double res3 = ds.MultiplyOfDigits(99);
            Assert.AreEqual(0, res3);

            double res4 = ds.MultiplyOfDigits(1000);
            Assert.AreEqual(0, res4);
        }
    }
}
