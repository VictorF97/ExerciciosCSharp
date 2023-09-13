using System;
//Fazer um método que imprima na tela os números de 0 a 100 e imprima se o número é par ou ímpar
namespace LogicaExs
{
    internal class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Mostraremos na tela os números de 0 à 100");
            Console.ReadLine();

            Numeros();
        }
        public static void Numeros()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                if (i % 2 == 1)
                {
                    Console.WriteLine("Ímpar");
                }
                else
                {
                    Console.WriteLine("Par");
                }
            }

        }
    }
}
