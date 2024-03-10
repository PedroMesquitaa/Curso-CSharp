using System.ComponentModel.Design;

namespace AreaCircunferencia
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

            Console.WriteLine("..:: Calcular Área da Circunferência ::..");
            Console.WriteLine("1 - Abrir calculadora");
            Console.WriteLine("2 - Sair");

            Console.WriteLine("---------");

            Console.WriteLine("Digite a opção:");
            short opcao = short.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1: Calculadora(); break;
                case 2: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Calculadora()
        {
            Console.Clear();

            Console.WriteLine("Calculadora");
            Console.WriteLine("Digite o valor de pi:");
            float pi = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do raio:");
            float raio = float.Parse(Console.ReadLine());

            float quadrado = raio * raio;
            float area = pi * quadrado;

            Console.WriteLine("\n..:: Resultado ::..");
            Console.WriteLine($"A área da circunferência é: {area:F2}");

            Console.ReadKey();
            Menu();
        }
    }
}