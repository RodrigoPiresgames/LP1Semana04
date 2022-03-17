using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gibe num to fibo");
            string aux = Console.ReadLine();
            int n =Convert.ToInt32(aux);
            Fibonacci(n);
        }
        private static int Fibonacci (int n)
        {
            int fibo;
            if (n == 1 || n == 2)
                fibo = 1;
            else
                fibo = Fibonacci(n - 2) + Fibonacci(n - 1);
            return fibo;
        }
    }
}
