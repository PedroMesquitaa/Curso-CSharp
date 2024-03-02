namespace GastoTotal
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

            Console.WriteLine("..:: Calculadora de Gasto Total ::..");
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
            Console.WriteLine("Digite o valor da sua mensalidade na faculdade:");
            float menFacul = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu custo com transporte:");
            float transporte = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu gasto com alimentção na faculdade:");
            float alimentacao = float.Parse(Console.ReadLine());

            float vlTotalMensal = menFacul + transporte + alimentacao;
            float vlTotalAnualMen = menFacul * 12;
            float vlTotalAnualTransp = transporte * 12;
            float vlTotalAnualAl = alimentacao * 12;
            float gastoTotalAnual = vlTotalAnualMen + vlTotalAnualTransp + vlTotalAnualAl;

            Console.WriteLine("\n..:: Relatório ::..");
            Console.WriteLine($"Seu gasto total no mês: {vlTotalMensal:F2}");
            Console.WriteLine($"Seu gasto anual com a mensalidade da faculdade: {vlTotalAnualMen:F2}");
            Console.WriteLine($"Seu gasto anual com transporte: {vlTotalAnualTransp:F2}");
            Console.WriteLine($"Seu gasto anual com alimentação: {vlTotalAnualAl:F2}");
            Console.WriteLine($"\nSeu gasto total anual: {gastoTotalAnual:F2}");

            Console.ReadKey();
            Menu();
        }
    }
}