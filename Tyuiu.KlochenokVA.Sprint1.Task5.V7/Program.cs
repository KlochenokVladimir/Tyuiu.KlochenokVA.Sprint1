using Tyuiu.KlochenokVA.Sprint1.Task5.V7.Lib;

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

double f;

Console.WriteLine("Введите значение f: ");
f = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine(" Полное количество часов прошедших от начала суток = " + ds.AngleToHoursMinutes(f));
Console.ReadLine();