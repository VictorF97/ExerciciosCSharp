using System;
//Exercício de código de usuário e senha
namespace LogicaExs
{
    class Ex4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu id de usuário: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Login(id);
            Console.ReadKey();
        }
        public static void Login(int id)
        {
            if(id == 1234) {                
                Console.WriteLine("Digite sua senha: ");
                int senha = Convert.ToInt32(Console.ReadLine());

                if (senha == 9999)
                {
                    Console.WriteLine("Acesso permitido!");
                } else
                {
                    Console.WriteLine("Senha inválida!");
                }
            } else
            {
                Console.WriteLine("Acesso negado!");
            } 
        }
    }
}
