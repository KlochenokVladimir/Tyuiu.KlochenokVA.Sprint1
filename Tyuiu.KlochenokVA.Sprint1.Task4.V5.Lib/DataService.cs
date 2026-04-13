using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KlochenokVA.Sprint1.Task4.V5.Lib
{
    public class DataService : ISprint1Task4V5
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round(1 / Math.Abs(x + Math.Sqrt(y)), 3);
            return res;
        }
    }
}
