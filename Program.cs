using System;

namespace Olá_Usuário
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.Write("\n");
            Console.WriteLine($"Olá, {nome}!");
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadKey();
        }
    }
}
