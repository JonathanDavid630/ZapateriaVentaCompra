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

        // Referencia al modelo
        MProducto mProducto = new MProducto();


        public void Insertar(Producto producto) //2 - Se recibe de la vista
        {
            mProducto.Insertar(producto); // 3-  Se envía al modelo
        }

        //public void Actualizar(List<Producto> productos)
        //{
        //    mProducto.Actualizar(productos);
        //}
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

        // public Producto ConsultarUno(int id)
        //{
        //   return mProducto.ConsultarUno(id);
        // }


    }
}
