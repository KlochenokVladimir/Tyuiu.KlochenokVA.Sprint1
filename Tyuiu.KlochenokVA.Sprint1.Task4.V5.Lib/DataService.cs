﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KlochenokVA.Sprint1.Task4.V5.Lib
{
    public class DataService : ISprint1Task4V5
    {
        public double Calculate(double x, double y)
        {
            double res = 1 / Math.Abs(x + Math.Sqrt(y));
            return Math.Round(res, 3);
        }
    }
}
