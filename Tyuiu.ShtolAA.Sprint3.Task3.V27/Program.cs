using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShtolAA.Sprint3.Task3.V27.Lib;


namespace Tyuiu.ShtolAA.Sprint3.Task3.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Штоль А.А. | ИИПБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Штоль Александра Алексеевна | ИИПБ-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach удалить все буквы и знаки препинания,            *");
            Console.WriteLine("* оставить цифру затем преобразовать в число в строке: !bt, g567kid f!    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "!bt,g567kid f!";

            Console.WriteLine("Исходная строка = " + value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Получившаяся строка : " + ds.ConvertStringToInt(value));
            Console.ReadKey();
        }
    }
}
