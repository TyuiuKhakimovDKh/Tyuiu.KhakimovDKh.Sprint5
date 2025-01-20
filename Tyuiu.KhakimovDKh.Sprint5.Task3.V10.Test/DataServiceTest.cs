using Tyuiu.KhakimovDKh.Sprint5.Task3.V10.Lib;

namespace Tyuiu.KhakimovDKh.Sprint5.Task3.V10.Test
{
     [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\KhakimovDKh\source\repos\Tyuiu.KhakimovDKh.Sprint5\Tyuiu.KhakimovDKh.Sprint5.Task3.V10\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileUnfo = new FileInfo(path);
            bool fileInfo = fileUnfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileInfo);
        }
    }
}
