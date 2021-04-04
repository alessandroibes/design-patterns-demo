using DesignPatterns.Creational.AbstractFactory;
using System;

namespace DesignPatterns
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Abstract Factory");

            var opcao = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            switch (opcao.KeyChar)
            {
                case '1':
                    ExecucaoAbstractFactory.Executar();
                    break;
                default:
                    Console.WriteLine("Tecla inválida, tente novamente.");
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            Console.WriteLine("Pressione qualquer tecla para reiniciar.");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
