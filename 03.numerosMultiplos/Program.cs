using System;

namespace _03.numerosMultiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma de todos os números impares que são múltiplos de três e que se encontram no conjunto dos numeros de 1 até 500");

            int somador = 0;
            

            for (int i = 0; i <=500; i++)
            {
                int numero = 0 + i;
                int impar = numero % 2;
                int divisivel = numero % 3;

                if(impar != 0 && divisivel == 0)
                {
                    somador = i + somador;

                }

               
                

            }
            Console.WriteLine("A soma dos numeros impares e multiplos de 3 é: " + somador);
            Console.ReadLine();
        }
    }
}
