using ZapateriaVentaCompra.Entidades;
using ZapateriaVentaCompra.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaVentaCompra.Controladores
{
    public class CProducto
    {

        MProducto mProducto = new MProducto();


        public void Insertar(Producto producto)
        {
            mProducto.Insertar(producto);
        }

     
        public void Actualizar(Producto producto)
        {
            mProducto.Actualizar(producto);
        }

        public void Eliminar(Producto producto)
        {
            mProducto.Eliminar(producto);
        }

        public List<Producto> Consultar()
        {
            return mProducto.Consultar();
        }

    }
}
