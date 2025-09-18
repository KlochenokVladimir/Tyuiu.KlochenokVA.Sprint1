using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KlochenokVA.Sprint1.Task2.V22.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KlochenokVA.Sprint1.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.Sqr(x);
            Assert.AreEqual(4, res);
        }
    }
}
