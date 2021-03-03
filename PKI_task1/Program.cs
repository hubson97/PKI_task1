using System;

namespace PKI_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"W pierwszym branchu; 2+3={Policz(2,3)}");
        }

        static int Policz(int a, int b)
        {
            return a + b;
        }
    }
}
