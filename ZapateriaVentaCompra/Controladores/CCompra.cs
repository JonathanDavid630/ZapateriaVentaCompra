using ZapateriaVentaCompra.Entidades;
using ZapateriaVentaCompra.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario.Controladores
{
    public class CCompra
    {
        MCompra mCompra = new MCompra();

        public void GuardarCompra(List<DetallesCompras> listado)
        {
            mCompra.GuardarCompra(listado);
        }
    }
}