using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperations
{

    public class ArithmeticMeanTwoNumbers
    {
        private double a;
        private double b;
        public ArithmeticMeanTwoNumbers()
        {
            this.a = 0;
            this.b = 0;
        }
        public ArithmeticMeanTwoNumbers(double userA, double userB)
        {
            if (userA == 0 || userB == 0)
                throw new ArgumentNullException();
            else 
            {
                this.a = userA;
                this.b = userB;
            }
                
        }
        public double getA()
        {
            return this.a;
        }
        public double getB()
        {
            return this.b;
        }
        public void setA(double value)
        {
            if (value == 0)
                throw new ArgumentNullException();
            else this.a = value;
        }
        public void setB(double value)
        {
            if (value == 0)
                throw new ArgumentNullException();
            else this.b = value;
        }
        public double Solve()
        {
            double result = 0;

            result += (this.a + this.b) / 2;

            return result;
        }
        public void printSolve()
        {
            Console.WriteLine(Solve());
        }
    }
   
}
