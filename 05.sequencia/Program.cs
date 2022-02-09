using System;

namespace _05.sequencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            int valorA = Convert.ToInt32(Console.ReadLine());
            int resultado = 1;

            for (int i = 0; i < valorA; i++)
            {

                resultado = (valorA- i) * resultado;
            }
            Console.WriteLine("esultado= " + resultado);
            Console.ReadLine();
        }
    }
}
