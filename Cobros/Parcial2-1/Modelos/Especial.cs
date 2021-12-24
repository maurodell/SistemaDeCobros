using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_1.Modelos
{
    public class Especial : Cobro
    {
        public Especial()
        {
            Adicional = 0.02;
            Recargo = 1000;
        }
    }
}
