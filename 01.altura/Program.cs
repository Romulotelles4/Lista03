using System;

namespace _01.altura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal maior = 0, menor, i = 0;

            Console.WriteLine("Informe o 1° número");
            decimal altura = Convert.ToDecimal(Console.ReadLine());
            maior = altura;
            menor = altura;
            i = 1;

            for (i = 2; i <= 15; i++)
            {
                Console.WriteLine("Informe o " + i + "° número:");
                altura = Convert.ToDecimal(Console.ReadLine());


                if (altura < menor)
                {
                    menor = altura;
                }

                if (altura > maior)
                {
                    maior = altura;
                }

            }
            Console.WriteLine("A menor altura é: " + menor);
            Console.WriteLine("A maior altura é: " + maior);
            Console.ReadLine();


        }
    }
}
