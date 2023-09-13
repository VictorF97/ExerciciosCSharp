using System;

//Fazer um método que imprima na tela os números de 0 a 100 e imprima se o número é primo ou não.
namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex11
    {
        public //Exercício 11
        static void Main(string[] args)
        {
            Console.WriteLine("Descobrirem quais são os números primos de 0 a 100");
            Console.ReadKey();

            Primo();
        }
        public static void Primo()
        {
            int n = 0;
            while (n <= 100)
            {
                n += 1;

                int divisores = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                        divisores++;
                }
                if (divisores == 2)
                {
                    Console.WriteLine("é primo", n);
                }
                else
                {
                    Console.WriteLine("não é primo", n);
                }
            }
        }
    }
}