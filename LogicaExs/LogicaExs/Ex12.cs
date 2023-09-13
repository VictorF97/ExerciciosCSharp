using System;
//Criar um método que recebe o nome de uma fruta, e retorne a letra inicial da fruta

namespace LogicaExs
{
    internal class Ex12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome de uma fruta: ");
            string fruta = Console.ReadLine();

            LetraInicial(fruta); 
        }
        public static void LetraInicial(string fruta)
        {
            string letraInicial = fruta[0].ToString();
            Console.WriteLine("A letra inicial da fruta digitada é: " + letraInicial);
        }
    }
}
