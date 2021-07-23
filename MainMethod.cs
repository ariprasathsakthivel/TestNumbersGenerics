using System;
using System.Collections.Generic;

namespace TestMaximum
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            TestMaximumGenerics<int> numbers = new TestMaximumGenerics<int>(10, 9, 8);
            numbers.MaxofThree();
            TestMaximumGenerics<double> decimalValues = new TestMaximumGenerics<double>(10.2, 10.3, 10.1);
            decimalValues.MaxofThree();
            TestMaximumGenerics<string> characterCollection = new TestMaximumGenerics<string>("Apple", "Peach", "Banana");
            characterCollection.MaxofThree();
        }
    }
}
