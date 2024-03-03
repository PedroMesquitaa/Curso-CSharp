namespace VolumeLataDeOleo
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

            Console.WriteLine("..:: Calculadora de Volume ::..");
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
            Console.WriteLine("Digite a altura da lata de óleo:");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o raio da lata de óleo:");
            float raio = float.Parse(Console.ReadLine());

            float raioAoQuadrado = raio * raio;
            double volume = 3.14 * raioAoQuadrado * altura;

            Console.WriteLine("\n..:: RESULTADO ::..");
            Console.WriteLine($"O volume da lata de óleo é: {volume:F2}");

            Console.ReadKey();
            Menu();
        }
    }
}