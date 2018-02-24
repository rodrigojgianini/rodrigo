using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Valor B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Calcular calcular = new Calcular()
            {
                ValorA = a,
                ValorB = b
            };


            int r = calcular.Somar();

            Console.WriteLine("Soma: "+ r);

            Console.ReadKey();
        }
    }
}
