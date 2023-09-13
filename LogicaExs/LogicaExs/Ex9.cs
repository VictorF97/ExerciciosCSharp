using System;
//Criar um método que recebe duas strings e retorna elas concatenadas
namespace LogicaExs
{
    internal class Ex9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Concatenação de Palavras");
            Console.WriteLine("Digite uma palavra: ");
            string palavra1 = Console.ReadLine();

            Console.WriteLine("Digite outra palavra: ");
            string palavra2 = Console.ReadLine();

            string concatenar = Resultado(palavra1, palavra2);
            Console.ReadLine();
        }

        public static void Resultado(string palavra1, string palavra2)
        {
            string concatenar = palavra1 + palavra2;
            return concatenar;
        }
    }
}
