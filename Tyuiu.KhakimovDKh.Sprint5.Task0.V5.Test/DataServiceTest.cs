using System.IO;
using Tyuiu.KhakimovDKh.Sprint5.Task0.V5.Lib;

namespace Tyuiu.KhakimovDKh.Sprint5.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempPath();
            FileInfo ra = new FileInfo(path);
            bool fileEx = ra.Exists;
            Assert.AreEqual(true, fileEx);
        }
    }
}
