using System;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxofThree(9.9,10.2,10.3);
        }
        public static void MaxofThree(double num1,double num2,double num3)
        {
            if (num1.CompareTo(num2)>0 && num1.CompareTo(num3)>0)
            {
                Console.WriteLine("number1 is the maximum number");
            }
            else if (num2.CompareTo(num1)>0 && num2.CompareTo(num3)>0)
            {
                Console.WriteLine("number2 is the maximum number");
            }
            else
            {
                Console.WriteLine("number3 is the maximum number");
            }
        }
    }
}
