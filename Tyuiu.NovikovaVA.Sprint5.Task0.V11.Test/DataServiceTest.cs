using Tyuiu.NovikovaVA.Sprint5.Task0.V11.Lib;
namespace Tyuiu.NovikovaVA.Sprint5.Task0.V11.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            
            string path = @"C:\Users\User\source\repos\Tyuiu.NovikovaVA.Sprint5\Tyuiu.NovikovaVA.Sprint5.Task0.V11\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(fileExists, wait);
        }
    }
}