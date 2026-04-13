using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KlochenokVA.Sprint1.Task6.V3.Lib;
namespace Tyuiu.KlochenokVA.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "Напечатать строку составленную из последних литер всех слов";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(strTest);
            string wait = "ьуюзхрхв";
            Assert.AreEqual(wait, res);
        }
    }
}