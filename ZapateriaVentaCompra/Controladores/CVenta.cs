using ZapateriaVentaCompra.Entidades;
using ZapateriaVentaCompra.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaVentaCompra.Controladores
{
    public class CVenta
    {
        MVentas mVenta = new MVentas();

        public void GuardarVenta(List<DetallesVentas> listado)
        {
            mVenta.GuardarVenta(listado);
        }
    }
}
