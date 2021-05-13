using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaVentaCompra.Entidades
{
    public class DetallesVentas
    {
        private Producto idProducto;

        public Producto IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }


        private int idDetalleVenta;

        public int IdDetalleVenta
        {
            get { return idDetalleVenta; }
            set { idDetalleVenta = value; }
        }

        private int camtidad;

        public int Cantidad
        {
            get { return camtidad; }
            set { camtidad = value; }
        }

        private int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private Producto producto;

        public  Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        private Ventass ventass;

        public Ventass Ventass
        {
            get { return ventass; }
            set { ventass = value; }
        }
    }
}
