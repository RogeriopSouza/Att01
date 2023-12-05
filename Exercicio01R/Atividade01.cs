using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01R
{
    public class Atividade01
    {
        public static void Executar()
        {
            Console.WriteLine("INFORME O VALOR DE A");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("INFORME O VALOR DE B");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("INFORME O VALOR DE C");
            int c = int.Parse(Console.ReadLine());

            if ((a + b) < c)
            //o if faz a função do SE 
            {

                Console.WriteLine("A soma de A + B é menor que o valor de C");
            }
            else
            {
                Console.WriteLine($"A soma de A + B {a+b} Não é menor que C");
            }

            Console.ReadKey();
            Console.Clear();
        }

    }
}

