namespace MediaFinalLP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("..:: NOTAS FINAIS ::..");
            Console.WriteLine("1 - Abrir a calculadora");
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
            Console.WriteLine("Digite a nota da atividade do primeiro semestre:");
            float atv1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota EAD do primeiro semestre:");
            float ead1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da avaliação do primeiro semestre:");
            float av1 = float.Parse(Console.ReadLine());

            Console.WriteLine("---------");

            Console.WriteLine("Digite a nota da atividade do segundo semestre:");
            float atv2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota EAD do segundo semestre:");
            float ead2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da avaliação do segundo semestre:");
            float av2 = float.Parse(Console.ReadLine());


            double n1 = (atv1 * 0.2) + (ead1 * 0.2) + (av1 * 0.6);
            double n2 = (atv2 * 0.2) + (ead2 * 0.2) + (av2 * 0.6);
            double mediaFinal = (n1 + n2) / 2;

            Console.WriteLine("\n..:: Boletim Final ::..");
            Console.WriteLine($"Nota da N1: {n1:F1}");
            Console.WriteLine($"Nota da N2: {n2:F1}");
            Console.WriteLine($"Média Final: {mediaFinal:F1}");

            Console.ReadKey();
            Menu();
        }
    }
}