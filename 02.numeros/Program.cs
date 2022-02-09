using System;

namespace _02.numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números ímpares de 100 a 200");

            for (int i = 0; i < 100; i++)
            {
                int numero = 100 + i;
                int teste = numero % 2;

                if (teste != 0)
                {
                    Console.Write(numero + ", ");
                }
                Console.ReadLine();

            }
        }
    }
}
