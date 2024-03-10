namespace DiferencaValores
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

            Console.WriteLine("..:: Diferença de Valores ::..");
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
            Console.WriteLine("Digite um número:");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            float n2 = float.Parse(Console.ReadLine());

            if(n1 > n2)
            {
                float diferenca1 = n1 - n2;
                Console.WriteLine($"{n1} é o maior número. A diferença do menor para o maior é de: {diferenca1}");
            }

            else if(n2 > n1)
            {
                float diferenca2 = n2 - n1;
                Console.WriteLine($"{n2} é o maior número. A diferença do menor para o maior é de: {diferenca2}");
            }

            else if(n1 == n2)
            {
                Console.WriteLine("Os dois números tem o mesmo valor. Tente novamente...");
            }

            Console.ReadKey();
            Menu();
        }
    }
}