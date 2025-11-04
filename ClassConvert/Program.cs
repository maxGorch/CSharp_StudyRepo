using System;
using System.Globalization;

namespace ClassConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "5";

            int str1ConvertInt = Convert.ToInt32(str1);

            string str2 = "10";

            int str2ConvertInt = Convert.ToInt32(str2);

            Console.WriteLine(str1ConvertInt + str2ConvertInt);


            string str3 = "1.25";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
             
            double str3ToDouble = Convert.ToDouble(str3,numberFormatInfo);

            Console.WriteLine(str3ToDouble + str3ToDouble);


        }
    }
}
