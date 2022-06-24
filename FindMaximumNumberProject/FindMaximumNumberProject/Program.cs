using System;

namespace FindMaximumNumberProject
{
    internal class Program
    {
        static void Main(string[] arg)
        {
             Console.WriteLine("Find Maximum Number");

            //int[] arr = { 112, 344, 456, 555, 876 };
            //GenericMaximum<int> generic = new GenericMaximum<int>(arr);
            //generic.PrintMaxValues();

            var genericint = GenericMax<int>.MaxValue(20, 30, 80);
           Console.WriteLine(genericint);
            var genericString = GenericMax<String>.MaxValue("40", "50", "60");
            Console.WriteLine(genericString);
            var genericdouble = GenericMax<double>.MaxValue(20.20, 40.20, 60.20);
            Console.WriteLine(genericdouble);


        }
    }
}
