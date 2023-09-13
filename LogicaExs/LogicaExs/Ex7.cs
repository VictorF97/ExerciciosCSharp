using System;
//Faça um algoritmo que calcule e escreva a média aritmetica dos números inteiros
// entre 15 e 100
namespace LogicaExs
{
    internal class Ex7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iremos descobrir a média aritmética dos números 15 até 100");

            Aritmetica();
            Console.ReadKey();
        }
        public static void Aritmetica()
        {
            int soma = 0;
            for(int i = 15; i <= 100; i ++)
            {
                soma += i;
            }

            int media = soma / 87;
            Console.WriteLine("a Soma dos números é: " + soma + "e sua média é: " + media);
        }
    }
}
