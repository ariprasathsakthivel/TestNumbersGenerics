using System;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxofThree(10,2, 11);
        }
        public static void MaxofThree(int num1,int num2,int num3)
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
