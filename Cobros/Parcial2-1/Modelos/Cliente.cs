using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_1.Modelos
{
    public class Cliente
    {
        public Cliente()
        {
            cobrosClientes = new List<Cobro>();

            cobrosPagadosClientes = new List<Cobro>();
        }
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public List<Cobro> cobrosClientes;


        public List<Cobro> cobrosPagadosClientes;


        public void AgregarCobro(Cobro pCobro)
        {
            cobrosClientes.Add(pCobro);
        }

        public void CobrosCancelados(Cobro pCobro)
        {
            cobrosPagadosClientes.Add(pCobro);
        }
    }
}
