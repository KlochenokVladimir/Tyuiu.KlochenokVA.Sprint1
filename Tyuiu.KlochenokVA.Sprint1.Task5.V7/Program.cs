using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KlochenokVA.Sprint1.Task5.V7.Lib;


namespace Tyuiu.KlochenokVA.Sprint1.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Клоченок В. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                             *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #7                                                             *");
            Console.WriteLine("* Выполнил: Клоченок Владимир Алексеевич | ИСПб-25-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до    *");
            Console.WriteLine("* того момента (в первой половине дня), когда часовая стрелка повернулась*");
            Console.WriteLine("* на f градусов (0<f<360, f – вещественное число).                       *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("* f = 90                                                                 *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.Write("Введите значение f (в градусах): ");
            double f = Convert.ToDouble(Console.ReadLine());

            int result = ds.AngleToHoursMinutes(f);
            Console.WriteLine($"Полных часов прошло: {result}");

            Console.ReadLine();
        }
    }
}
