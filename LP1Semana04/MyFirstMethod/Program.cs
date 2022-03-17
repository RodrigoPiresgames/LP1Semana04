using System;

namespace NomeDoProjeto
{
    /// <summary>
    /// Programa que vai escrever na consola todos os numeros inteiros ate ao numero dito pelo user
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main, onde se vai chamar tudo
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string aux = Console.ReadLine();
            int n = Convert.ToInt32(aux);
            CountToN(n);
            aux = Console.ReadLine();
            n = Convert.ToInt32(aux);
            CountToN(n);
        }
        /// <summary>
        /// Recebe um numero e vai escrever um a um todos os inteiros des de 1 ate n
        /// </summary>
        /// <param name="n">Ultimo numero escrito</param>
        private static void CountToN(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(n);
            }
        }

    }
}
