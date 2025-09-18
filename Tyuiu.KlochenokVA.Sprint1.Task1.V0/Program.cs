using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KlochenokVA.Sprint1.Task1.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите первое число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            
            int average = (firstNumber + secondNumber + thirdNumber) / 3;

            Console.WriteLine("Среднее значение: " + average);
        }
    }
}
