using System;
//Criar um método que recebe um número inteiro e retorne uma string dizendo se o número é par ou impar.
namespace LogicaExs
{
    internal class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero % 2 == 1)
            {
                Console.WriteLine("O número digitado é ímpar");
            }else
            {
                Console.WriteLine("O número digitado é par");
            }
        }
    }
}
