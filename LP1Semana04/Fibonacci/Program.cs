using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gibe num to fibo");
            string aux = Console.ReadLine();
            int n = ToInt34(aux);
            Fibonacci(n);
        }
        private static int Fibonacci (int n)
        {
            ulong fibo;
            if (n == 1 || n == 2)
                fibo = 1;
            else
                fibo = fibo(n - 2) + fibo (n - 1);
            return fibo;
        }
    }
}
