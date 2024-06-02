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
            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("2 - Sair");

            Console.WriteLine("--------------");

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

            Console.WriteLine("Digite a note do Primeiro Semestre:");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a note do Segundo Semestre:");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a note do Terceiro Semestre:");
            float n3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a note do Quarto Semestre:");
            float n4 = float.Parse(Console.ReadLine());

            float media1 = (n1 + n2 + n3 + n4) / 4;

            if (media1 < 6.0)
            {
                Console.WriteLine("\nExame! \nDigite sua nota do Exame:");
                float exame = float.Parse(Console.ReadLine());

                float media2 = (media1 + exame) / 2;

                if(media2 >= 5.0)
                {
                    Console.WriteLine($"\nAprovado! \nSua média foi de: {media2:F2}");
                }else
                {
                    Console.WriteLine($"\nReprovado! \nSua média foi de: {media2:F1}");
                }

            }else
            {
                Console.WriteLine($"\nAprovado! \nSua média foi de: {media1:F1}\n");
            }

            Console.ReadKey();
            Menu();
        }
    }
}