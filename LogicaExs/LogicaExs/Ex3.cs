using System;

namespace LogicaExs
{
    class Ex3
    {
        //Exercício de Frutas
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a fruta comprada, '1' ou '2': ");
            float fruta = float.Parse(Console.ReadLine());

            Console.WriteLine("informe os Kgs comprados: ");
            float kg = float.Parse(Console.ReadLine());

            ValorTotal(fruta, kg);
            Console.ReadKey();
        }

        public static void ValorTotal(double fruta, double kg)
        {
            if(fruta == 1)
            {
                if(kg <= 5) {
                    double precoMorango = 2.50;
                    double valor = kg * precoMorango;
                    Console.WriteLine("O total a ser pega nos morangos é de: " + valor);
                }else if (kg <= 8)
                {
                    double precoMorango = 2.20;
                    double valor = kg * precoMorango;
                    Console.WriteLine("O total a ser pago nos morangos é de: " + valor);
                } else if (kg > 8)
                {
                    double precoMorango = 2.20;
                    double valor = kg * precoMorango;
                    double desconto = valor * 0.1;
                    double valorFinal = valor - desconto;
                    Console.WriteLine("O total a ser pago nos morangos é de: " + valorFinal);
                }
            }

            if(fruta == 2) 
            { 
                if(kg <= 5)
                {
                    double precoMaca = 1.80;
                    double valor = kg * precoMaca;
                    Console.WriteLine("O total a ser pega nas maças é de: " + valor);
                } else if(kg <= 8)
                {
                    double precoMaca = 1.50;
                    double valor = kg * precoMaca;
                    Console.WriteLine("O total a ser pega nas maças é de: " + valor);
                }else if (kg > 8)
                {
                    double precoMaca = 1.50;
                    double valor = kg * precoMaca;
                    double desconto = valor - 0.1;
                    double valorFinal = valor - desconto;
                    Console.WriteLine("O total a ser pega nas maças é de: " + valorFinal);
                }
            }
        }
    }
}
