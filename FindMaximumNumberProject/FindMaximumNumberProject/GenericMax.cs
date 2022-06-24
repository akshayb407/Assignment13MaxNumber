using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumberProject
{
    internal class GenericMax<T> where T : IComparable
    {
        ///<summary>
        ///this is method is created for maximum to std output using using generic Method
        ///</summary>
        public  T firstValue, secondValue, thirdValue;
        public GenericMax(T firstValue, T sewcondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = sewcondValue;
            this.thirdValue = thirdValue;
        }
        public static T MaxValue(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;

            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;

            }
            return default;

        }
        public T MaxMethod()
        {
            T max = GenericMax<T>.MaxValue(this.firstValue, this.secondValue, this.thirdValue);
            return max;
        }
    }
}
