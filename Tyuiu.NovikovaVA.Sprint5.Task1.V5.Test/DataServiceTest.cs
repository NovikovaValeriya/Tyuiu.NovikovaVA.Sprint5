using Tyuiu.NovikovaVA.Sprint5.Task1.V5.Lib;
namespace Tyuiu.NovikovaVA.Sprint5.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(fileExists, wait);
        }
    }
}