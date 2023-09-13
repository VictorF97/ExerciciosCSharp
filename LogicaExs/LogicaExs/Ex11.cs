using System;
//Criar um método que recebe 4 notas bimestrais e retorne a média
namespace LogicaExs
{
    internal class Ex11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Notas Bimestrais");
            Console.WriteLine("Informe a sua primeira nota: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a sua segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a sua terceira nota: ");
            float nota3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a sua quarta nota: ");
            float nota4 = float.Parse(Console.ReadLine());

            Notas(nota1, nota2, nota3, nota4);
        }

        public static void Notas(float nota1, float nota2, float nota3, float nota4)
        {
            float media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("A média das suas notas bimestral é de: " + media);
            Console.ReadLine();
        }
    }
}
