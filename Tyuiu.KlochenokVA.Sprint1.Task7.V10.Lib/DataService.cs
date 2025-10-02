using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KlochenokVA.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {
            double numerator = Math.Log(Math.Cos(x));
            double denominator = Math.Log(1 + Math.Pow(x, 2));

            double result = 2 * (1 / Math.Tan(3 * x)) - (numerator / denominator);

            return Math.Round(result, 3);
        }
    }
}
