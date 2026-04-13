using Tyuiu.KlochenokVA.Sprint1.Task2.V22.Lib;

namespace Tyuiu.KlochenokVA.Sprint1.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 10;
            int b = 10;
            int c = 10;
            var res = ds.CalculateAVGValue(a, b, c);
            Assert.AreEqual(10, res);
        }
    }
}