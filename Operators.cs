using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100 + 50;
            int sum1 = 100 + 200;
            int sum2 = sum1 + x;
            int sum3 = sum2 + x;
            Console.WriteLine(x);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
        }
    }
}