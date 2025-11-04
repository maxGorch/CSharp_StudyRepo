using System;
using System.Globalization;

namespace Parse_TryParse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "125";
            string str2 = "1.25";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            int str1ToIntConvert = Convert.ToInt32(str1);
            int str1ToIntParse = int.Parse(str1);

            double str2ToDoubleConvert = Convert.ToDouble(str2,numberFormatInfo);
            double str2ToDoubleParse = double.Parse(str2, numberFormatInfo);

            Console.WriteLine("Преобразование string в int используя Convert, Parse");
            Console.WriteLine("С помощью Convert "+str1ToIntConvert);
            Console.WriteLine("С помощью Parse "+str1ToIntParse);

            Console.WriteLine("\nПреобразование string в double используя Convert, Parse");
            Console.WriteLine("С помощью Convert " + str2ToDoubleConvert);
            Console.WriteLine("С помощью Parse " + str2ToDoubleParse);

            double doub1 = 1.75;
            int doub1ToIntConvert = Convert.ToInt32(doub1);
            Console.WriteLine("\nПреобразование double в int используя Convert");
            Console.WriteLine("С помощью Convert " + doub1ToIntConvert);

            int str2ToIntParse;
            bool tryStr2ToIntParse = int.TryParse(str2, out str2ToIntParse);
            Console.WriteLine("\nПреобразование double в int используя Parse");
            if (tryStr2ToIntParse)
            {
                Console.WriteLine("С помощью Parse " + str2ToIntParse);
            }
            else
            {
                Console.WriteLine("Не получилось преобразовать!");
            }
                

        }
    }
}
