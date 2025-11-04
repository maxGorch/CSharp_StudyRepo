using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperations.ArithmeticOperations
{
    class ReadThreeNumbersAndWriteSummMulti
    {
        public static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите значение для первого числа: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение для второго числа: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение для третьего числа: ");
            c = double.Parse(Console.ReadLine());

            double summThreeNumbers = a + b + c;
            Console.WriteLine("Сумма трех чисел: " + summThreeNumbers);

            double multThreeNumbers = a * b * c;
            Console.WriteLine("Сумма трех чисел: " + multThreeNumbers);
        }

    }
}
