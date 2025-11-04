using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertValut
{
    internal class ConvertValut
    {
        static void Main(string[] args)
            //Из рублей в доллары
        {

            double oneDollarIntoRuble = 80.93;

            Console.WriteLine("Какую сумму вы хотел ли бы перевести из рублей в доллары?");
            double userNumber = double.Parse(Console.ReadLine());

            double formulaConvert = userNumber / oneDollarIntoRuble;

            Console.WriteLine("Вот сумма в долларах: " + Math.Round(formulaConvert,2));

        }
    }
}
