using System;

namespace NomeDoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux = Console.ReadLine();
            int n = Convert.ToInt32(aux);
            CountToN(n);
            aux = Console.ReadLine();
            n = Convert.ToInt32(aux);
            CountToN(n);
        }

        private static void CountToN(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(n);
            }
        }

    }
}
