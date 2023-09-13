using System;

namespace LogicaExs
{
    class Ex2
    {
        //Exercício idade de Homens e Mulheres
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a idade do primeiro homem: ");
            int idadeH1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a idade do primeiro homem: ");
            int idadeH2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a idade da primeira mulher: ");
            int idadeM1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a idade da primeira mulher: ");
            int idadeM2 = Convert.ToInt32(Console.ReadLine());

            Idades(idadeH1, idadeH2, idadeM1, idadeM2);
            Console.ReadKey();
        }

        public static void Idades(int idadeH1, int idadeH2, int idadeM1, int idadeM2)
        {
            if((idadeH1 > idadeH2) && (idadeM1 > idadeM2)) {
                int soma = idadeH1 + idadeM2;
                int produto = idadeH2 * idadeM1;

                Console.WriteLine("A soma das idades do homem mais velho com a mulher mais nova é de: " + soma);
                Console.WriteLine("O produto das idades do homem mais novo e da mulher mais velha é de: " + produto);
            }
            else if ((idadeH2 > idadeH1) && (idadeM1 > idadeM2))
            {
                int soma = idadeH2 + idadeM2;
                int produto = idadeH1 * idadeM1;
                Console.WriteLine("A soma das idades do homem mais velho com a mulher mais nova é de: " + soma);
                Console.WriteLine("O produto das idades do homem mais novo e da mulher mais velha é de: " + produto);
            }

            else if ((idadeH2 > idadeH1) && (idadeM2 > idadeM1))
            {
                int soma = idadeH2 + idadeM1;
                int produto = idadeH1 * idadeM2;
                Console.WriteLine("A soma das idades do homem mais velho com a mulher mais nova é de: " + soma);
                Console.WriteLine("O produto das idades do homem mais novo e da mulher mais velha é de: " + produto);
            }
            else if ((idadeH1 > idadeH2) && (idadeM2 > idadeM1))
            {
                int soma = idadeH1 + idadeM2;
                int produto = idadeH2 * idadeM1;
                Console.WriteLine("A soma das idades do homem mais velho com a mulher mais nova é de: " + soma);
                Console.WriteLine("O produto das idades do homem mais novo e da mulher mais velha é de: " + produto);
            }
        }
    }
}
