using System;
//Fazer um método que retorne a média da soma dos números de 10 a 90.
namespace LogicaExs
{
    internal class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Descobriremos a soma e média dos números de 10 à 90");

            Media();
            Console.ReadKey();
        }
        public static void Media()
        {
            int soma = 0;
            for (int i = 10; i <= 90; i++)
            {
                soma += i;
                Console.WriteLine(i);
            }

            int media = soma / 82;
            Console.WriteLine("a Soma dos números é: " + soma + " e sua média é: " + media);
        }
    }
}
