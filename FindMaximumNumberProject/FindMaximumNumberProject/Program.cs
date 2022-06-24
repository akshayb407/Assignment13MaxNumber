using System;

namespace FindMaximumNumberProject
{
    internal class Program
    {
        static void Main(string[] arg)
        {
             Console.WriteLine("Find Maximum Number");
            int[] arr = { 112, 344, 456, 555, 876 };
            GenericMaximum<int> generic = new GenericMaximum<int>(arr);
            generic.PrintMaxValues();


        }
    }
}
