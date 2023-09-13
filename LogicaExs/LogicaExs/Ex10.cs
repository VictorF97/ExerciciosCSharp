using System;
//Criar um método que recebe dois inteiros e retorna a soma deles
namespace LogicaExs
{
    internal class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Somar(numero1, numero2);
        }

        public static void Somar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            Console.WriteLine("A soma dos números digitados é de: " + resultado);
            Console.ReadLine();
        }
    }
}
