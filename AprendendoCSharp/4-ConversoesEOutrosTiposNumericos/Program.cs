using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            //O int é uma variável de 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int) salario;
            Console.WriteLine("Salário em inteiro: " + salarioEmInteiro);

            //O long é uma variável de 64 bits
            long idade = 13000000000000;
            Console.WriteLine(idade);

            //o short é uma variável de 16 bits;
            short quantidadeDeProdutos = 150;
            Console.WriteLine(quantidadeDeProdutos);

            //Float é um tipo de variável tbm de ponto flutuante assim como o double
            //porém com menos precisão após a virgula
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("A execução terminou. Tecle enter para finalizar.");
            Console.ReadLine();
        }
    }
}
