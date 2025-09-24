using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KlochenokVA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.KlochenokVA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int res1 = ds.AngleToHoursMinutes(90);
            Assert.AreEqual(3, res1);

            int res2 = ds.AngleToHoursMinutes(29.9);
            Assert.AreEqual(0, res2);

            int res3 = ds.AngleToHoursMinutes(359);
            Assert.AreEqual(11, res3);
        }
    }
}
