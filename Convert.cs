using System;

namespace Myexample
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 23;
            double myDouble = 23.23;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool));
        }
    }
}