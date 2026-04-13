using Tyuiu.KlochenokVA.Sprint1.Task5.V7.Lib;
namespace Tyuiu.KlochenokVA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double f = 10;
            DataService ds = new DataService();
            int result = ds.AngleToHoursMinutes(f);

            int wait = 0;
            Assert.AreEqual(wait, result);
        }
    }
}