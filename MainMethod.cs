using System;
using System.Collections.Generic;

namespace TestMaximum
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            TestMaximumGenerics<int> numbers = new TestMaximumGenerics<int>(51,82,101,2000,125,150,55,85);
            numbers.MaxofThree();
            TestMaximumGenerics<double> decimalValues = new TestMaximumGenerics<double>(10.2, 10.3, 10.1, 50.25, 9.2, 8.5, 500.33, 101.6, 60.3);
            decimalValues.MaxofThree();
            TestMaximumGenerics<string> characterCollection = new TestMaximumGenerics<string>("Apple", "Peach", "Banana","Orange","Watermelon");
            characterCollection.MaxofThree();
        }
    }
}
