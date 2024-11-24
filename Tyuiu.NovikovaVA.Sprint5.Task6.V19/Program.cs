using Tyuiu.NovikovaVA.Sprint5.Task6.V19.Lib;
namespace Tyuiu.NovikovaVA.Sprint5.Task6.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Новикова В.А. | ИСТН-б-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:                                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Новикова Валерия Александрован | ИСТНб-24-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\Users\User\source\repos\Tyuiu.NovikovaVA.Sprint5\DataSprint5\InPutDataFileTask6V19.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество двузначных элементов файла = " + res);
            Console.ReadKey();
        }
    }
}
