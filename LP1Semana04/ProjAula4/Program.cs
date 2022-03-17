using System;

namespace NomeDoProjeto
{
    /// <summary>
    /// Programa que vai escrever na consola todos os numeros inteiros de um numero ate outro ambos dados por ordem pelo user
    /// </summary>
    class Program
    {
        /// <summary>
        /// Vao ser pedidos dois numeros e executado CountToN 2 vezes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for(int i = 0; i < 2; i++)
            {
                string aux = Console.ReadLine();
                int n1 = Convert.ToInt32(aux);
                aux = Console.ReadLine();
                int n2 = Convert.ToInt32(aux);
                CountToN(n1, n2);
            }
        }
        /// <summary>
        /// Recebe dois numeros e vai escrever um a um todos os inteiros des do primeiro ate ao segundo
        /// </summary>
        /// <param name="n1">Primeiro numero a ser escrito</param>
        /// <param name="n2">Ultimo numero a ser escrito</param>
        private static void CountToN(int n1, int n2)
        {
            for(int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
