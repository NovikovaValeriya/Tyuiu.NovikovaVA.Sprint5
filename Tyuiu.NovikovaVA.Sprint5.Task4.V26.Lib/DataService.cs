using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NovikovaVA.Sprint5.Task4.V26.Lib
{
    public class DataService : ISprint5Task4V26
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            string str1 = str.Replace(".", ",");
            double x = Convert.ToDouble(str1);
            double res = Math.Round( (Math.Pow(x, 3) + Math.Sin(x))*Math.Cos(x), 3);
            return res;
        }
    }
}
