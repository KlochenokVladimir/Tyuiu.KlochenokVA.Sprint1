using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KlochenokVA.Sprint1.Task4.V5.Lib;

namespace Tyuiu.KlochenokVA.Sprint1.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(2, 9);
            Assert.AreEqual(0.2, res);

            res = ds.Calculate(-4, 4);
            Assert.AreEqual(0.5, res);
        }
    }
}
