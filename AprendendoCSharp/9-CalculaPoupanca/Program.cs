using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Calcula Poupaça");

            double valorInvestido = 300000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                //0.36% = 0.0036
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine("Após {0} mês, você terá R$ " + valorInvestido.ToString("F2"), contadorMes);
                contadorMes++;
            }

            Console.ReadLine();
        }
    }
}
