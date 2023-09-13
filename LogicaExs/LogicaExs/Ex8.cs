using System;
//Criar um método que recebe duas strings e print na tela elas concatenadas
namespace LogicaExs
{
    internal class Ex8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra: ");
            string palavra1 = Console.ReadLine();

            Console.WriteLine("Digite outra palavra: ");
            string palavra2 = Console.ReadLine();
        
            Concatenacao(palavra1, palavra2);
        }

        public static void Concatenacao(string palavra1, string palavra2)
        {
            string resultado = palavra1 + palavra2;
            Console.WriteLine("A concatenação das palavras é: " + resultado);
            Console.ReadLine();
        }
    }
}
