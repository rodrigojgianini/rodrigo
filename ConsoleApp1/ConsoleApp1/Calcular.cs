using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calcular
    {
        #region Propriedades

        public int ValorA { get; set; }
        public int ValorB { get; set; }

        #endregion Propriedades

        #region Métodos

        public int Somar()
        {
            return ValorA + ValorB;
        }

        #endregion Métodos

    }
}
