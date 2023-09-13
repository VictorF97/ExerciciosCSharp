using System;
//Crie um método que calcule o fatorial de um inteiro passado como parâmetro
namespace LogicaExs
{
    internal class Ex19
    {
        public static void Main(string[] args)
        {
            int fatorial = 1;
            for (int i = 1; i <= 10; i++)
            {
                fatorial = i * fatorial;
                Console.WriteLine("O fatorial de " + i + "  é: " + fatorial);
            }
        }
    }
}
