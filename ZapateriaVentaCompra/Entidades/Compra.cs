using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaVentaCompra.Entidades
{
    public class Compra
    {
        private int idCompra;

        public int IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }



        private List<DetallesCompras> detallesCompra;

        public List<DetallesCompras> DetallesCompra
        {
            get { return detallesCompra; }
            set { detallesCompra = value; }
        }

        public Compra()
        {
            this.detallesCompra = new List<DetallesCompras>();
        }
    }
}