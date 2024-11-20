using Tyuiu.NovikovaVA.Sprint5.Task5.V10.Lib;
namespace Tyuiu.NovikovaVA.Sprint5.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\source\repos\Tyuiu.NovikovaVA.Sprint5\DataSprint5\InPutDataFileTask5V10.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}