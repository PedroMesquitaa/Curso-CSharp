namespace DiasVividos
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

            Console.WriteLine("..:: Calculadora de Dias vividos ::..");
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

            Console.WriteLine("Calculadora\n");
            Console.WriteLine("Digite seu ano de nascimento:");
            int anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual:");
            int anoAtual = int.Parse(Console.ReadLine());

            int diasHoje = (anoAtual - anoNascimento) * 365;

            Console.WriteLine("\n..:: Relatório ::..");
            Console.WriteLine($"Quantidade de dias vividos: {diasHoje}\n");

            Console.ReadKey();
            Menu();
        }
    }
}