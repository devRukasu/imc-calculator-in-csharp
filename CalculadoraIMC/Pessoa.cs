using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    internal class Pessoa
    {
        public float peso;
        public float altura;
        public float resultado;
        public string situacao;

        public double CalcularIMC()
        {
            resultado = peso / (altura * altura);
            return resultado;
        }

        public string TabelaIMC()
        {
            if (resultado < 18.5)
                situacao = "Abaixo do Peso";
            else if (resultado < 25)
                situacao = "Peso Normal";
            else if (resultado < 30)
                situacao = "Acima do Peso";
            else if (resultado < 35)
                situacao = "Obesidade I";
            else if (resultado < 40)
                situacao = "Obesidade II";
            else
                situacao = "Obesidade III";

            return situacao;
        }

        public void Mensagem()
        {
            Console.WriteLine($"A sua situação é {situacao}");
        }
    }
}
