using System;

namespace EquacaoSegundoGrau
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

            Console.WriteLine("..:: Calculadora de Bhaskara ::..");
            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("2 - Sair");

            Console.WriteLine("----------------");

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

            Console.WriteLine("Digite o valor de a:");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de b:");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de c:");
            float c = float.Parse(Console.ReadLine());

            float delta = (b * b) - 4 * (a * c);

            if (delta <= 0)
            {
                Console.WriteLine("Delta não pode ser menor ou igual a Zero! Tente novamente.");
            }else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("..:: Resultado ::..");
                Console.WriteLine($"Delta: {delta:F1}");
                Console.WriteLine($"X1: {x1:F1}");
                Console.WriteLine($"X2: {x2:F1}");
            }

            Console.ReadKey();
            Menu();
        }
    }
}