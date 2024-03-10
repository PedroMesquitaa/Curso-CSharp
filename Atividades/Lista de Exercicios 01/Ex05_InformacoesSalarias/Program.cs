using System.ComponentModel.Design;

namespace InformacoesSalarios
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

            Console.WriteLine("..:: Calculara Salário ::..");
            Console.WriteLine("1 - Abrir calculadora");
            Console.WriteLine("2 - Sair");

            Console.WriteLine("---------");

            Console.WriteLine("Escolha a opção:");
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
            Console.WriteLine("Digite quanto você ganha por hora:");
            float salPorHora = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos dias na semana você trabalha:");
            float diasTrabalhados = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantas horas você trabalha por dia:");
            float horasDia = float.Parse(Console.ReadLine());

            double horasSemanal = horasDia * diasTrabalhados;
            double salarioBrutoMensal = 1.1 * horasSemanal * 4 * salPorHora;
            double irDesconto = (salarioBrutoMensal / 1.05) - salarioBrutoMensal;
            double inssDesconto = (salarioBrutoMensal / 1.07) - salarioBrutoMensal;
            double descontoTotal = - (irDesconto + inssDesconto);
            double salarioLiqMensal = salarioBrutoMensal - descontoTotal;

            Console.WriteLine("\n..:: Folha de Pagamento ::..");
            Console.WriteLine($"Salário Bruto Mensal: {salarioBrutoMensal:F2}");
            Console.WriteLine($"Desconto de IR 5%: {irDesconto:F2}");
            Console.WriteLine($"Desconto de INSS 7%: {inssDesconto:F2}");
            Console.WriteLine($"\nSalário Líquido: {salarioLiqMensal:F2}");

            Console.ReadKey();
            Menu();
        }
    }
}