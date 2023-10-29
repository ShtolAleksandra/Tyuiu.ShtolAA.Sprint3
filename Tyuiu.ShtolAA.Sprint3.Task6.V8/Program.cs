using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtolAA.Sprint3.Task6.V8.Lib;

namespace Tyuiu.ShtolAA.Sprint3.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Штоль А.А. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры  C#                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Штоль Александра Алексеевна | ИИПб-23-3                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Напишите программу, которая ищет среди целых чисел,            *");
            Console.WriteLine("* принадлежащих числовому отрезку [18, 28] сумму всех делителей больше 11 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 18;
            int stopValue = 28;
            Console.WriteLine(" Начало отрезка = " + startValue);
            Console.WriteLine(" Конец отрезка = " + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Сумма всех делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
