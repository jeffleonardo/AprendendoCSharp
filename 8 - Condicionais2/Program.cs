using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8");

            int idadejoao = 16;
            //int quantidaDePessoas = 2;

            //bool acompanhado = quantidaDePessoas >= 2;
            bool acompanhado = true;
            bool idadeJoao = idadejoao > 18;

            if (idadeJoao && acompanhado)
            {
                Console.WriteLine("João pode entrar");
            }
            else
            {
                Console.WriteLine("João não pode entrar");
            }

            int idade = 68;
            bool ehIdoso = idade >= 65;

            Console.ReadLine();
        }
    }
}
