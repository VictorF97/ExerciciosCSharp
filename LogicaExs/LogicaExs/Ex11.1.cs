using System;
//Quando você chama o método anterior você deve pegar o resultado dele e imprimir na tela
//se a média for menor que 5 o aluno está reprovado, se a média for entre 5 e 7 ele está
//de recuperação se a nota for maior que 7 ele está aprovado
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

        if (media < 5)
        {
            Console.WriteLine("Aluno reprovado!");
        }
        else if (media < 7)
        {
            Console.WriteLine("Aluno de recuperação!");
        }
        else
        {
            Console.WriteLine("Aluno aprovado!");
        }
    }
}
}
