using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaVentaCompra.Entidades
{
    public class DetallesCompras
    {
        private int idDetalleCompra;

        public int IdDetalleCompra
        {
            get { return idDetalleCompra; }
            set { idDetalleCompra = value; }
        }

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private Producto producto;

        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        private Compra compra;

        public Compra Compra
        {
            get { return compra; }
            set { compra = value; }
        }
    }
}
