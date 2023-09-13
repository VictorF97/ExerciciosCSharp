using System;
// Praticando os exercícios anteriores... Crie um método eu escreva na tela “Iniciando o Programa”,
// crie um método que receba o nome do usuário e escreva na tela “Bem-vindo [nomeUsuario]”,
// crie um método que receba dois números e retorne a soma deles, crie um método que pega a soma anterior
// e retorne a média, crie um método que pegue a soma anterior e diga se o valor é par ou impar.
namespace LogicaExs
{
    internal class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o Programa");

            Console.WriteLine("Digite o seu nome de usuário: ");
            string nomeUsuario = Console.ReadLine();
            NomeUsuario(nomeUsuario);


            Console.WriteLine("Iremos realizar a soma de dois número");
            Console.WriteLine("Digite um número: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            float numero2 = float.Parse(Console.ReadLine());

            float soma = Somar(numero1, numero2);

            Media(numero1, numero2);

            ImparPar(soma);


        }
        public static string NomeUsuario(string nomeUsuario)
        {
            Console.WriteLine("Seja bem-vindo " + nomeUsuario);
            return nomeUsuario;
        }

        public static float Somar(float numero1, float numero2)
        {
            float soma = numero1 + numero2;
            Console.WriteLine("A soma dos números " + numero1 + " e " + numero2 + " é igual a: " + soma);
            return soma;
        }

        public static void Media(float numero1, float numero2)
        {
            float media = (numero1 + numero2) / 2;
            Console.WriteLine("A média dos números " + numero1 + " e " + numero2 + " é igual a: " + media);
        }

        public static void ImparPar(float soma)
        {
            if (soma % 2 == 1)
            {
                Console.WriteLine("A soma " + soma + " é ímpar");
            }
            else
            {
                Console.WriteLine("A soma " + soma + " é par");
            }
        }
    }
}