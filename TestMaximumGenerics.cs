using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    class TestMaximumGenerics<T> where T : IComparable<T>
    {
        List<T> values = new List<T>();
        public TestMaximumGenerics(params T[] values)
        {
            foreach (T element in values)
            {
                this.values.Add(element);
            }
        }
        public void MaxofThree()
        {
            this.values.Sort();
            Console.WriteLine(this.values[this.values.Count-1]);
        }
    }
}
