using System;

namespace NegativoPositvo
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("..:: Conversor para Positivo ::..");
            Console.WriteLine("1 - Abrir calculadora");
            Console.WriteLine("2 - Sair");

            Console.WriteLine("---------");

            Console.WriteLine("Digite a opção:");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Calculadora(); break;
                case 2: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Calculadora()
        {
            Console.Clear();

            Console.WriteLine("Calculadora de Negativo para Positivo");
            Console.WriteLine("Digite um número negativo ou positivo:");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("..:: Resultado ::..");
            if(n1 <= 0)
            {
                float n2 = n1 * -1;
                Console.WriteLine($"{n2}, Aqui está seu número convertido para Positivo!\n");
            }else
            {
                Console.WriteLine($"{n1}, Seu número ja era Positivo!\n");
            }

            Console.ReadKey();
            Menu();
        }
    }
}