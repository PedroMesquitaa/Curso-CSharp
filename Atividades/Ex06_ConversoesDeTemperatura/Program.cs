using System.ComponentModel.Design;

namespace CoversoesDeTemperatura
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

            Console.WriteLine("..:: Conversor de Fahrenheit ::..");
            Console.WriteLine("1 - Abrir conversor");
            Console.WriteLine("2 - Sair");

            Console.WriteLine("---------");

            Console.WriteLine("Digite a opção:");
            short opcao = short.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1: Conversor(); break;
                case 2: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Conversor()
        {
            Console.Clear();

            Console.WriteLine("Conversor");
            Console.WriteLine("Digite qunatos graus (Celsius) está o dia de hoje: ");
            int grausCelsius1 = int.Parse(Console.ReadLine());

            int grausCelsius2 = (grausCelsius1 / 5) * 9;
            int grausFahrenheit = grausCelsius2 + 32;

            Console.WriteLine("\n..:: Resultado ::..");
            Console.WriteLine($"Temperatura em Fahrenheit: {grausFahrenheit}");

            Console.ReadKey();
            Menu();
        }
    }
}