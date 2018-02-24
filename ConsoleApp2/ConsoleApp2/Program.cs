using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite os anos: ");
            int anos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite os meses: ");
            int meses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite os dias: ");
            int dias = Convert.ToInt32(Console.ReadLine());
            int resultado = 0;

            Calcular calcular = new Calcular()
            {
                Anos = anos,
                Meses = meses,
                Dias = dias
            };

            Console.WriteLine (resultado = calcular.CalculoDias());
            Console.ReadKey();
        }
    }
}
