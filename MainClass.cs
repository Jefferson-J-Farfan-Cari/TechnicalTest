using System;

namespace TechnicalTest
{
    class MainClass
    {
        static void Main(string[] args)
        {
            ChristmasBatteries cb = new ChristmasBatteries();
            // int B, int N, int X, int Y, int Z, int M);
            // int a = cb.MostFun(0, 5, 1, 1, 1, 1000); // 1
            // int a = cb.MostFun(3, 5, 1, 1, 1, 1000); // 14
            // int a = cb.MostFun(3, 5, 1, 1, 1, 13); // 11
            // int a = cb.MostFun(4, 10000, 123, 456, 789, 1); // 0
            // int a = cb.MostFun(7, 4, 3, 5, 7, 997); // 100
            int a = cb.MostFun(2, 12345, 234, 34, 5, 117); //143371
            Console.WriteLine("Returns: " + a);
        }
    }
}
