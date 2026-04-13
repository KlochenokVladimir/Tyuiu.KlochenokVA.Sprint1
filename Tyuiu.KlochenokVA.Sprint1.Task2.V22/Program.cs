using Tyuiu.KlochenokVA.Sprint1.Task2.V22.Lib;
namespace Tyuiu.KlochenokVA.Sprint1.Task2.V22
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Клоченок В. А. | ИСПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                              Спринт #1                                  *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("*                              Задание #2                                 *");
            Console.WriteLine("*                              Вариант #22                                *");
            Console.WriteLine("* Выполнил: Клоченок Владимир Алексеевич    | ИСПб-25-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("* Заданы три числа. Вычислить среднее значение из них.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("***************************************************************************");



            int a, b, c;
            Console.WriteLine("Введите значение a ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение b ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение c ");
            c = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CalculateAVGValue(a, b, c));
            Console.ReadLine();


        }
    }
}
