using System;

namespace Power2Method
{
    class Program
    {
        /// <summary>
        /// Main metedo que vai chamar o PowersOf2UntilN duas vezes com valores diferentes
        /// </summary>
        /// <param name="args">NA</param>
        static void Main(string[] args)
        {
            PowersOf2UntilN(7);
            PowersOf2UntilN(6);
            PowersOf2UntilN(8,9);
            PowersOf2Until5();

        }

        /// <summary>
        /// Chama PowersOf2UntilN com o valor 5
        /// </summary>
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(5);
        }

        /// <summary>
        /// Vai imprimir todos os numeros de 2 elevado a n
        /// </summary>
        /// <param name="n">numero final a que o dois vai tar elevado</param>
        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// vai imprimir todos os numeros de 2 elevado a n entre n1 e n2
        /// </summary>
        /// <param name="n1">numero inicial a que o dois vai tar elevado</param>
        /// <param name="n2">numero final a que o dois vai tar elevado</param>
        private static void PowersOf2UntilN(int n1, int n2)
        {
            for (int i = (1 << n1); i <= (1 << n2); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
        //&& (1 << n1) <= 
    }
}
