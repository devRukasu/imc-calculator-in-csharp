using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite o seu peso");
            pessoa.peso = System.Single.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua altura");
            pessoa.altura = System.Single.Parse(Console.ReadLine());

            pessoa.CalcularIMC();
            pessoa.TabelaIMC();
            pessoa.Mensagem();
        }
    }
}
