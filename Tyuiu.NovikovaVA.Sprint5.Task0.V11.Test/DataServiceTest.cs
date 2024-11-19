using Tyuiu.NovikovaVA.Sprint5.Task0.V11.Lib;
namespace Tyuiu.NovikovaVA.Sprint5.Task0.V11.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(fileExists, wait);
        }
    }
}