using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    class TestMaximumGenerics<T> where T : IComparable<T>
    {
        T value1, value2, value3;
        public TestMaximumGenerics(T value1,T value2, T value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }
        public void MaxofThree()
        {
            if (this.value1.CompareTo(this.value2) > 0 && this.value1.CompareTo(this.value3) > 0)
            {
                Console.WriteLine("value1 is the maximum number");
            }
            else if (this.value2.CompareTo(this.value1) > 0 && this.value2.CompareTo(this.value3) > 0)
            {
                Console.WriteLine("value2 is the maximum number");
            }
            else
            {
                Console.WriteLine("value3 is the maximum number");
            }
        }
    }
}
