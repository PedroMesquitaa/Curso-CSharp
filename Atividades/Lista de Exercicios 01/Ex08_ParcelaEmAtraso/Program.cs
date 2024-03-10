namespace ParcelaEmAtraso
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

            Console.WriteLine("..:: PRESTAÇÃO DA PARCELA ::..");
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
            Console.WriteLine("Digite o valor da prestação:");
            float vlInicial = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem da taxa a cada 30 dias:");
            float taxa = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos dias de atraso:");
            float atraso = float.Parse(Console.ReadLine());

            float taxa2 = taxa / 100;
            float taxaDeJuros = (taxa2 / 30) * atraso * vlInicial;
            float vlFinal = vlInicial + taxaDeJuros;

            Console.WriteLine("\n..:: RELATÓRIO ::..");
            Console.WriteLine($"Valor inicial da prestação: {vlInicial:F2}");
            Console.WriteLine($"Valor da taxa de juros sobre os dias atrasados: {taxaDeJuros:F2}");
            Console.WriteLine($"\nValor Final da prestação: {vlFinal:F2}");

            Console.ReadKey();
            Menu();
        }
    }
}