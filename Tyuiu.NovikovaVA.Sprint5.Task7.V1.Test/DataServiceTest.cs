using Tyuiu.NovikovaVA.Sprint5.Task7.V1.Lib;
namespace Tyuiu.NovikovaVA.Sprint5.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.NovikovaVA.Sprint5\DataSprint5\InPutDataFileTask7V1.txt";
            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}