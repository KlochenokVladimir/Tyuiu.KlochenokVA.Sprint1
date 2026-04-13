using Tyuiu.KlochenokVA.Sprint1.Task7.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Клоченок В. А. | ИСПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Клоченок Владимир Алексеевич | ИСПб-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("***************************************************************************");

        double x;
        Console.WriteLine("Введите значение x (диапозон от -1 до 1): ");
        x = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        if (1 >= x && x >= -1)
        {
            Console.WriteLine($"Ваш результат {ds.Calculate(x)}");
        }
        else
        {
            Console.WriteLine("Такое значение x недопустимо");
        }
    }
}