using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 2 - Faça um programa repita exatamente que o usuário digitar, gritando (em CAIXA ALTA).

            Console.Write("Você fala: ");
            string answer = Console.ReadLine();
            Console.WriteLine($"\nO Gritador repete: {answer.ToUpper()}");
        }
    }
}
