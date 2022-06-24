using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumberProject
{
    public class GenericMaximum<T> where T : IComparable
    {

        ///<summary>
        ///this is method is created for Maximum Method to take more than 3 parameters and used Sorting
        ///</summary>


        public T[] value;
        public GenericMaximum(T[]value)
        {
            this.value = value;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);   
            return sorted_values[^1];

        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;

        }
        public void PrintMaxValues()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }
        
    }
    
}
