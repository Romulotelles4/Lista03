using System;

namespace _04.tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 0 a 10: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int nu = N * i;

                Console.WriteLine(N + "X" + i + "=" + nu);
            }
            Console.ReadLine();
        }
    }
}
