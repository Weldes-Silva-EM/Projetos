using System;

namespace forEachLoop
{
    class Program
    {

        static void Main()
        {
            ForEachLoopExample();
        }

        static void ForEachLoopExample()
        {
            String[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (var c in carTypes)
            {
                Console.WriteLine(c);
            }

            int[] myInts = { 10, 20, 30, 40 };
            foreach (var i in myInts)
            { 
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
