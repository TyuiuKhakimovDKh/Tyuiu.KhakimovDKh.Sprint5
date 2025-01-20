using Tyuiu.KhakimovDKh.Sprint5.Task2.V23.Lib;

namespace Tyuiu.KhakimovDKh.Sprint5.Task2.V23.Test;
[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void Test_SaveToFileTextData_FileExists()
    {
        // Arrange
        int[,] testMatrix = new int[3, 3]
        {
            { 7, 2, 8 },
            { 6, 9, 1 },
            { 2, 3, 5 }
        };

        DataService ds = new DataService();// Act
        string resultPath = ds.SaveToFileTextData(testMatrix);

        // Assert
        Assert.IsTrue(File.Exists(resultPath), "Файл не был создан.");
    }

    [TestMethod]
    public void Test_SaveToFileTextData_CorrectValues()
    {
        // Arrange
        int[,] testMatrix = new int[3, 3]
        {
            { 7, 2, 8 },
            { 6, 9, 1 },
            { 2, 3, 5 }
        };

        DataService ds = new DataService();

        // Act
        string resultPath = ds.SaveToFileTextData(testMatrix);

        string expectedContent = "0;2;8\n6;0;0\n2;0;0";
        string actualContent = File.ReadAllText(resultPath);

        // Assert
        Assert.AreEqual(expectedContent, actualContent, "Содержимое файла не совпадает с ожидаемым.");
    }
}