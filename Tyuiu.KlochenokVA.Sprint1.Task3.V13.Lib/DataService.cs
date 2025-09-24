using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KlochenokVA.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            int num = (int)number;

            if (num < 100 || num > 999)
            {
                return 0;
            }

            int a = num / 100;
            int b = (num / 10) % 10;
            int c = num % 10;

            double product = a * b * c;
            return Math.Round(product, 3);

        }
    }
}
