using Parcial2_1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_1.Datos
{
    public class ClienteAMB
    {
        public void Agregar(Cliente pCliente, List<Cliente> pListaclientes)
        {
            pListaclientes.Add(pCliente);
        }
        public void Borrar(Cliente pCliente, List<Cliente> pListaclientes)
        {
            try
            {
                Cliente _aux = pListaclientes.Find(x => x.Legajo == pCliente.Legajo);

                if (_aux != null)
                {
                    pListaclientes.Remove(_aux);
                }
                else
                {
                    throw new Exception("El cliente no existe!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void Modificar(Cliente pCliente, List<Cliente> pListaclientes)
        {
            try
            {
                Cliente _aux = pListaclientes.Find(x => x.Legajo == pCliente.Legajo);

                if (_aux != null)
                {
                    pListaclientes.Remove(_aux);
                    pListaclientes.Add(pCliente);
                }
                else
                {
                    throw new Exception("El cliente no existe!");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public List<Cliente> TraerCliente(List<Cliente> _listaCliente)
        {
            var lista = from c in _listaCliente
                        select c;

            return lista.ToList();
        }
        public bool Existe(Cliente pCliente, List<Cliente> pListaCliente)
        {
            bool flag = false;
            foreach (var item in pListaCliente)
            {
                if (item.Legajo == pCliente.Legajo)
                {
                    flag = true;
                    break;
                }
            }
            if (pListaCliente.Count == 0)
            {
                flag = false;
            }
            return flag;
        }
        public List<Cobro> CobrosDeUnCliente(Cliente pCliente, List<Cliente> pListaCliente)
        {
            List<Cobro> _auxLista = new List<Cobro>();
            try
            {
                Cliente _auxCliente = pListaCliente.Find(x=>x.Legajo == pCliente.Legajo);
                _auxLista = _auxCliente.cobrosClientes;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return _auxLista;
        }
    }
}
