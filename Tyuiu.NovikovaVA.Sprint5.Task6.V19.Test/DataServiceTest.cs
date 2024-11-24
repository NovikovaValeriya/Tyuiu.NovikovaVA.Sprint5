using Tyuiu.NovikovaVA.Sprint5.Task6.V19.Lib;
namespace Tyuiu.NovikovaVA.Sprint5.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\source\repos\Tyuiu.NovikovaVA.Sprint5\DataSprint5\InPutDataFileTask6V19.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckedExsistFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\source\repos\Tyuiu.NovikovaVA.Sprint5\DataSprint5\InPutDataFileTask6V19.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}