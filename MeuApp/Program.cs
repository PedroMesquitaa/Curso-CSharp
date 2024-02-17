using System;

namespace MeuApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeuMetodo();

            string nome = RetornaNome("Pedro", "Mesquita");
            Console.WriteLine(nome);
        }

        static void MeuMetodo()
        {
            Console.WriteLine("C# é legal");
        }

        static string RetornaNome(
            string nome, 
            string sobrenome, 
            int idade = 21
        )
        {
            return nome + " " + sobrenome + " tem " + idade.ToString() + " anos";
        }
    }
}
