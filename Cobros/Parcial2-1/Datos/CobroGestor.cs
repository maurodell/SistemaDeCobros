using Parcial2_1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_1.Datos
{
    public class CobroGestor
    {
        public void AgregarCobro(Cobro pCobro, List<Cobro> pListacobros)
        {
            pListacobros.Add(pCobro);
        }
        public List<Cobro> CobrosPorCliente(Cliente pCliente)
        {
            List<Cobro> _listaAux = new List<Cobro>();

            foreach (var cob in pCliente.cobrosClientes)
            {
                if (cob.Cancelado == false && pCliente.Legajo == cob.Cliente.Legajo)
                {
                    _listaAux.Add(cob);
                }
            }
            return _listaAux;
        }
        public bool Existe(Cobro pCobro, List<Cobro> pListaCobro)
        {
            bool flag = false;
            foreach (var item in pListaCobro)
            {
                if (item.Codigo == pCobro.Codigo)
                {
                    flag = true;
                    break;
                }
            }
            if (pListaCobro.Count == 0)
            {
                flag = false;
            }
            return flag;
        }
        public void ControlPago(Cobro pCobro)
        {
            pCobro.FechaPago = DateTime.Today;
            DateTime datFechaPago = DateTime.Today;
            TimeSpan dif = datFechaPago - pCobro.FechaVto;
            int dias = dif.Days;
            double importePagado = pCobro.ImporteACobrar;
            double recargo = pCobro.Recargo;
            if (dias>0)
            {
                recargo = pCobro.Recargo + pCobro.Adicional * pCobro.ImporteACobrar * dias;
                importePagado += recargo;
            }
            else
            {
                pCobro.Recargo = 0;
            }
            if (MessageBox.Show("Confirmar pago: \nImporte a pagar: $"+ pCobro.ImporteACobrar+
                                                "\nRecargo: $"+ recargo +
                                                "\nTotal a pagar: $"+ importePagado,
                                "PAGO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (var cobro in Form1._listaCobros)
                {
                    if (cobro.Codigo == pCobro.Codigo)
                    {
                        cobro.Cancelado = true;
                        cobro.ImportePagado = importePagado;
                        pCobro.Recargo = recargo;
                        MessageBox.Show("Pago Confirmado!");
                        break;
                    }
                }
            }
        }
        public List<Cobro> PagosCancelados(Cliente pCliente)
        {
            var listaCancelados = from c in pCliente.cobrosPagadosClientes
                                  where c.Cancelado == true
                                  select c;

            return listaCancelados.ToList();
        }
        public object CobrosPagados(Cliente pCliente, List<Cobro> _listaCobrosPagados)
        {
            var listaCobrosPagados = from c in _listaCobrosPagados
                                     where c.Cancelado == true && c.Cliente.Legajo == pCliente.Legajo
                                     select new
                                     {
                                         NombreCliente = c.Cliente.Nombre,
                                         ImportePagado = c.ImportePagado
                                     };
            return listaCobrosPagados.ToList();
        }
        public bool ExistePago(Cobro pCobro, Cliente pCliente)
        {
            bool flag = false;
            foreach (var item in pCliente.cobrosPagadosClientes)
            {
                if (item.Codigo == pCobro.Codigo)
                {
                    flag = true;
                    break;
                }
            }
            if (pCliente.cobrosPagadosClientes.Count == 0)
            {
                flag = false;
            }
            return flag;
        }
    }
}
