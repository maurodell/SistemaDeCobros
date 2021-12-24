using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_1.Modelos
{
    public class Normal : Cobro
    {
        public Normal()
        {
            Adicional = 0.01d;
            Recargo = 0;
        }
    }
}
