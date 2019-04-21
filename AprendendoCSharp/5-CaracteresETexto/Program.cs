using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Texto");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura cursos de tecnologia";
            string cursosProgramacao = @"- .NET
- Java
- JavaScript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("A execuçao terminou. Tecle enter para finalizar.");
            Console.ReadLine();
        }
    }
}
