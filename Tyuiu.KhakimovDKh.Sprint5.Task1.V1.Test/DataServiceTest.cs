using System.IO;

using Tyuiu.KhakimovDKh.Sprint5.Task1.V1.Lib;


namespace Tyuiu.KhakimovDKh.Sprint5.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\KhakimovDKh\source\repos\Tyuiu.KhakimovDKh.Sprint5\Tyuiu.KhakimovDKh.Sprint5.Task1.V1\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

