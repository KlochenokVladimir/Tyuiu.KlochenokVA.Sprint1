using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KlochenokVA.Sprint1.Task7.V10.Lib;


namespace Tyuiu.KlochenokVA.Sprint1.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedFormulaValid()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1.0);

            double expected = 2 * (1 / Math.Tan(3 * 1.0)) - (Math.Log(Math.Cos(1.0)) / Math.Log(1 + 1.0 * 1.0));
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, res);
        }
    }
}
