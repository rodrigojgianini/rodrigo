using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Calcular
    {
        #region Propriedades

        public int Anos { get; set; }
        public int Meses { get; set; }
        public int Dias { get; set; }

        #endregion Propriedades

        #region CalculoDias

        public int CalculoDias()
        {

            return ((Anos * 365) + (Meses * 30) + Dias);

        }

        #endregion CalculoDias
    }
}
