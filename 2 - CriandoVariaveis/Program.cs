using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;
            idade = 30;
            Console.WriteLine("Eu tenho " + idade + " anos");

            idade = 10 + 5 * 2;
            Console.WriteLine("Eu tenho " + idade + " anos");

            idade = (10 + 5) * 2;
            Console.WriteLine("Eu tenho " + idade + " anos");


            Console.Write("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
