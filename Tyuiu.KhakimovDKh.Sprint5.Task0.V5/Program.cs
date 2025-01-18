
using Tyuiu.KhakimovDKh.Sprint5.Task0.V5.Lib;
namespace Tyuiu.KhakimovDKh.Sprint5.Task0.V5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Хакимов Д.Х. | ИИПб-24-2";
            DataService ds = new DataService();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт#5                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
            Console.WriteLine("* Задание #0                                                                 *");
            Console.WriteLine("* Вариант #5                                                                 *");
            Console.WriteLine("* Выполнил: Хакимов Достонбек Хисравович | ИИПб-24-2                       *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                    *");
            Console.WriteLine("*Дано выражение вычислить его значение при x = 3, результат сохранить в      *");
            Console.WriteLine("*текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до трёх  *");
            Console.WriteLine("*знаков после запятой.                                                       *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*x=3                                                                         *");
            int x = 3;
            string path = ds.SaveToFileTextData(x);
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Файл: " + path);
            Console.WriteLine("создан!");
            Console.ReadKey();
        }
    }
}
