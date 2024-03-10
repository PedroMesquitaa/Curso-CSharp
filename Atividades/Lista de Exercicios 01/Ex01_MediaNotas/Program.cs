namespace MediaDeNotas
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

            Console.WriteLine("--Calculadora de Médias--");
            Console.WriteLine("1 - Abrir calculadora");
            Console.WriteLine("2 - Sair");

            Console.WriteLine("---------");

            Console.WriteLine("Digite a opção:");
            short escolha = short.Parse(Console.ReadLine());

            switch(escolha) // jeito alternativo de usar o if else
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
            Console.WriteLine("Digite a primeira nota:");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            float n3 = float.Parse(Console.ReadLine());

            float media = (n1 + n2 + n3) / 3;

            Console.WriteLine($"A média final é: {media:F1}");

            Console.ReadKey();
            Menu();
        }
    }
}


