using System;

namespace LogicaExs
{
    class Ex5
    {
        //Exercício de Aposentadoria
        public static void Main(string[] args)
        {
            Console.WriteLine("informe a idade do trabalhador: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o tempo de trabalho registrado pelo trabalhador: ");
            int tempo = Convert.ToInt32(Console.ReadLine());

            Aposentadoria(idade, tempo);
            Console.ReadKey();
        }

        public static void Aposentadoria(int idade, int tempo)
        {
            if(idade >= 65)
            {
                Console.WriteLine("Trabalhador está apto para se aposentar");

                if(tempo >=30)
                {
                    Console.WriteLine("Trabalhador está apto para se aposentar");

                    if((idade >= 60) && (tempo >= 25))
                    {
                        Console.WriteLine("Trabalhador está apto para se aposentar");
                    } else
                    {
                        Console.WriteLine("Trabalhador não está apto para se aposentar");
                    }
                }
            } 
        }
    }
}
