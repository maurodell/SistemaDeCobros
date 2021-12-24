using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Parcial2_1.Modelos
{
    public class Cobro : IComparable
    {
        public delegate void EventoAviso();
        public static event EventoAviso eventoAviso;

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaVto { get; set; }
        public double ImporteACobrar { get; set; }
        public bool Cancelado { get; set; }

        private double importePagado;
        public double ImportePagado 
        {
            get { return importePagado; }
            set 
            {
                if (value > 10000)
                {
                    eventoAviso();
                }
                importePagado = value;
            }
        }
        public DateTime FechaPago { get; set; }
        public double Adicional { get; set; }
        public double Recargo { get; set; }
        public Cliente Cliente { get; set; }

        //acá le indico al sort el parametro por el cual me ordena los objetos.
        public int CompareTo(object obj)
        {
            return this.ImportePagado.CompareTo((obj as Cobro).ImportePagado);
        }
    }
}
