using Tyuiu.KhakimovDKh.Sprint5.Task2.V23.Lib;

// Исходный массив
int[,] mtrx = new int[3, 3]
            {
            { 7, 2, 8 },
            { 6, 9, 1 },
            { 2, 3, 5 }
            };

int rows = mtrx.GetLength(0);
int cols = mtrx.GetLength(1);
DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнил: Хакимов Д.Х. | ИИПБ-24-2";
Console.WriteLine("************************************************************************** ");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #23                                                             *");
Console.WriteLine("* Выполнил: Хакимов Достонбек Хисравович  | ИИПБ-24-2                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный массив. Заменить нечетные элементы массива на 0           *");
Console.WriteLine("***************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine("***************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************");

string resultPath = ds.SaveToFileTextData(mtrx);

Console.WriteLine("Массив после преобразования:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");
    }
    Console.WriteLine();


    Console.WriteLine($"\nФайл с результатами создан: {resultPath}");
    Console.ReadKey();



}
              
        
            
    


