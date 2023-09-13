using System;
//Tabuada do 8
namespace LogicaExs
{
    internal class Ex6
    {
        public static void Main(string[] args)
        {
            int num = 8;
            int tabuada;

            for(int i = 1; i <= 10; i++) {
                tabuada = num * i;

                Console.WriteLine("A tabuada do 8 é: " + i + " = " + tabuada);
            }

        }
    }
}
