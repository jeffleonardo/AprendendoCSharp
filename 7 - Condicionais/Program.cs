using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7");

            int idadejoao = 16;
            int quantidaDePessoas = 2;

            if (idadejoao > 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade");
            }
            else
            {
                if (quantidaDePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado.");
                }
                else
                {
                    Console.WriteLine("João é menor de idade, não pode entrar.");
                }
            }

            Console.ReadLine();
        }
    }
}
