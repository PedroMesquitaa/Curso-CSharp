using System;

namespace MediaAritmetica
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

            Console.WriteLine("..:: Aluno Online ::..");
            Console.WriteLine("1 - Abrir a Calculadora");
            Console.WriteLine("2 - Sair");

            Console.WriteLine("---------");

            Console.WriteLine("Digite a opção:");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Calculadora(); break;
                case 2: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Calculadora()
        {
            Console.Clear();

            Console.WriteLine("Digite a note do Primeiro semestre:");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a note do Segundo semestre:");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a note do Terceiro semestre:");
            float n3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a note do Quarto semestre:");
            float n4 = float.Parse(Console.ReadLine());

            float media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("..:: Resultado ::..");
            if(media >= 6)
            {
                Console.WriteLine($"Aprovado! \nMédia Final: {media:F1}\n");
            }else
            {
                Console.WriteLine($"Reprovado! \nMédia Final: {media:F1}\n");
            }

            Console.ReadKey();
            Menu();
        }
    }
}