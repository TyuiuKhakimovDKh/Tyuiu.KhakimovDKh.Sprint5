using Tyuiu.KhakimovDKh.Sprint5.Task1.V1.Lib;
namespace Tyuiu.KhakimovDKh.Sprint5.Task1.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Хакимов Д.Х. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Хакимов Достонбек Хисравович  | ИИПБ-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Произвести табулирование функции на диапазоне от -5 до 5 с шагом 1.     *");
            Console.WriteLine("* При делении на 0 вернуть значение 0. Результат сохранить в текстовый    *");
            Console.WriteLine("* файл и вывести на консоль в таблицу.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
