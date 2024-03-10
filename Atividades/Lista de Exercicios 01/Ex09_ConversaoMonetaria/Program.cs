namespace ConversaoMonetaria
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

            Console.WriteLine("..:: CONVERSOR MONETÁRIO ::..");
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
            Console.WriteLine("Digite o valor em Reais:");
            float reais = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a cotação do Dolar:");
            float dolar = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a cotação do Euro:");
            float euro = float.Parse(Console.ReadLine());

            float vlDolar = reais / dolar;
            float vlEuro = reais / euro;

            Console.WriteLine("\n..:: RESULTADO ::..");
            Console.WriteLine($"Valor do Real para o Dolar: {vlDolar:F2}");
            Console.WriteLine($"Valor do Real para o Euro: {vlEuro:F2}");

            Console.ReadKey();
            Menu();
        }
    }
}