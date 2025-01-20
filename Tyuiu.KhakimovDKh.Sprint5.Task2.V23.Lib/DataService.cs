
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhakimovDKh.Sprint5.Task2.V23.Lib
{}
public class DataService : ISprint5Task2V23
{
        public string SaveToFileTextData(int[,] matrix)
        {
            // Генерация пути для сохранения
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            string text = "";

            // Замена нечетных элементов и формирование текста
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                    text += $"{matrix[i, j]};";
                }
                text = text.TrimEnd(';') + "\n";
            }

            // Запись в файл
            File.WriteAllText(path, text.TrimEnd('\n'));

            return path;
        }
    }
