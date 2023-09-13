using System;

namespace LogicaExs
{
    class Ex1
    {
        //Exercício do Posto de gasolina 
        static void Main(string[] args){

            float qntLitros;
            string tipoComb;

            Console.WriteLine("Informe quantos litros deseja abastecer: ");
            qntLitros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o tipo do combustivel, 'A' ou 'G': ");
            tipoComb = Console.ReadLine();

            ValorTotal(qntLitros, tipoComb);
            Console.ReadKey();
        }
        public static void ValorTotal(float qntLitros, string tipoComb)
        {
            if (tipoComb == "A")
            {
                double alcool = 2.90;

                if (qntLitros <= 20)
                {
                    double valorFinal = qntLitros * alcool - alcool * 0.03;
                    Console.WriteLine("O valor a ser paga é de: " + valorFinal);
                }
                else if (qntLitros > 20)
                {
                    double valorFinal = qntLitros * alcool - alcool * 0.05;
                    Console.WriteLine("O valor a ser paga é de: " + valorFinal);
                }
            }

            if (tipoComb == "G")
            {
                double gasolina = 3.30;

                if (qntLitros <= 20)
                {
                    double valorFinal = qntLitros * gasolina - gasolina * 0.04;
                    Console.WriteLine("O valor a ser paga é de: " + valorFinal);
                }
                else if (qntLitros > 20)
                {
                    double valorFinal = qntLitros * gasolina - gasolina * 0.06;
                    Console.WriteLine("O valor a ser paga é de: " + valorFinal);
                }
            }
        }
    }
} 
