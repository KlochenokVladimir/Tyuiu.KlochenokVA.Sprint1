using Tyuiu.KlochenokVA.Sprint1.Task4.V5.Lib;

namespace Tyuiu.KlochenokVA.Sprint1.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 0.25;
            Assert.AreEqual(wait, ds.Calculate(x, y));
        }
    }
}