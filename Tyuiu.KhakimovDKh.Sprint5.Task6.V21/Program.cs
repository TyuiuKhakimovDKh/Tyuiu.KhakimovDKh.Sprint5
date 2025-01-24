using Tyuiu.KhakimovDKh.Sprint5.Task6.V21.Lib;



namespace Tyuiu.KhakimovDKh.Sprint5.Task6.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Хакимов Д.Х. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Хакимов Достонбек Хисравович | ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл (файл взять из архива согласно вашему варианту. Создать папку  *");
            Console.WriteLine("* в ручную и скопировать в неё файл) в котором есть набор символьных      *");
            Console.WriteLine("* данных. Найти количество удвоенных букв тт в заданной строке.           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");


            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask6V21.txt";

            Console.WriteLine("Данные находяться в файле: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
