using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine(x > 3 || x < 4); // returns True because one of the conditions are True (5 is greater than 3, but 5 is not less than 4)
        }
    }
}