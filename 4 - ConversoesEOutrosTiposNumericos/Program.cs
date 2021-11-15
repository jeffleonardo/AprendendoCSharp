using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            int salarioInteiro; //int = 32bits
            salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);

            long idade; //long = 64bits
            idade = 26000000000;
            Console.WriteLine(idade);

            short quantidadeProdutos; //short = 16bits
            quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.70f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
