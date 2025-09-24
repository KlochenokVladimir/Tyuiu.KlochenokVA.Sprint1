using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KlochenokVA.Sprint1.Task2.V22.Lib;

namespace Tyuiu.KlochenokVA.Sprint1.Task1.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Клоченок В. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Арифмитические операторы в C#                                    *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #22                                                            *");
            Console.WriteLine("* Выполнил: Клоченок Владимир Алексеевич | ИСПб-25-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.            *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("* 1, 3, 5                                                                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");


            DataService dataService = new DataService();

            Console.Write("Введите первое число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            int averageValue = dataService.CalculateAVGValue(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine("Среднее значение: " + averageValue);
        }
    }
}
