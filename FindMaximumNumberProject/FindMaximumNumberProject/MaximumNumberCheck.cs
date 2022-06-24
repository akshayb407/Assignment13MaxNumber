using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumberProject
{
    internal class MaximumNumberCheck
    {

        ///<summary>
        ///this is method is created for maximum Float number
        ///</summary>
        public static double MaximumFloatNumber(double firstdouble, double seconddouble, double thirddouble)
        {
            if (firstdouble.CompareTo(seconddouble) > 0 && firstdouble.CompareTo(thirddouble) > 0 ||
                firstdouble.CompareTo(seconddouble) >= 0 && firstdouble.CompareTo(thirddouble) > 0 ||
                firstdouble.CompareTo(seconddouble) > 0 && firstdouble.CompareTo(thirddouble) >= 0)
            {
                return firstdouble;
            }
            if (seconddouble.CompareTo(firstdouble) > 0 && seconddouble.CompareTo(thirddouble) > 0 ||
                seconddouble.CompareTo(firstdouble) >= 0 && seconddouble.CompareTo(thirddouble) > 0 ||
                seconddouble.CompareTo(firstdouble) > 0 && seconddouble.CompareTo(thirddouble) >= 0)
            {
                return seconddouble;

            }
            if (thirddouble.CompareTo(firstdouble) > 0 && thirddouble.CompareTo(seconddouble) > 0 ||
                thirddouble.CompareTo(firstdouble) >= 0 && thirddouble.CompareTo(seconddouble) > 0 ||
                thirddouble.CompareTo(firstdouble) > 0 && thirddouble.CompareTo(seconddouble) >= 0)
            {
                return thirddouble;

            }
            throw new NotImplementedException("firstNumber, secondNumber, thirdNumber are same");

        }

      
    }
}
