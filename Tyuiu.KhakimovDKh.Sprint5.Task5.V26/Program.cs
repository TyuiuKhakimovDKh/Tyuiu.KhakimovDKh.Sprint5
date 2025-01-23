
using System.Globalization;
using Tyuiu.KhakimovDKh.Sprint5.Task5.V26.Lib;
namespace Tyuiu.KhakimovDKh.Sprint5.Task5.V26
{

    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Хакимов Д.Х | ИИПБ-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Хакимов Достонбек Хисравович     | ИИПб-24-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Найти разницу между суммой всех положительных и отрицательных вещественных*");
            Console.WriteLine("*чисел в файле. Результат округлить до 3 знаков после запятой. Полученный *");
            Console.WriteLine("*результат вывести на консоль. У вещественных значений округлить до трёх *");
            Console.WriteLine("*       знаков после запятой.                                             *");
            // Путь к файлу
            string directory = @"C:\DataSprint5";
            string fileName = "InPutDataFileTask5V26.txt";
            string filePath = Path.Combine(directory, fileName);

            Console.WriteLine("                               ИСХОДНЫЕ ДАННЫЕ                             ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Путь к файлу: {filePath}");
            Console.WriteLine("***************************************************************************");

            try
            {
                // Вычисление результата
                double result = ds.LoadFromDataFile(filePath);

                // Вывод результата
                Console.WriteLine("                               РЕЗУЛЬТАТ:                                  ");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine($"Разница между суммами положительных и отрицательных чисел: {result.ToString
                    ("F3", CultureInfo.InvariantCulture)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }

















}
