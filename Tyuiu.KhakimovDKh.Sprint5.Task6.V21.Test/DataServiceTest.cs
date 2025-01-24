
using Tyuiu.KhakimovDKh.Sprint5.Task6.V21.Lib;


namespace Tyuiu.KhakimovDKh.Sprint5.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\user\source\repos\Tyuiu.KhakimovDKh.Sprint5\DataSprint5\InPutDataFileTask6V21.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.KhakimovDKh.Sprint5\DataSprint5\InPutDataFileTask6V21.txt";


            FileInfo fileInfo = new FileInfo(path);
            bool fileexists = fileInfo.Exists;
            bool expect = true;
            Assert.AreEqual(expect, fileexists);
        }
    }
}
