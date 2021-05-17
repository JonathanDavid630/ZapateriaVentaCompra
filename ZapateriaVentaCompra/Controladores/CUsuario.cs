using ZapateriaVentaCompra.Entidades;
using ZapateriaVentaCompra.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaVentaCompra.Controladores
{
    public class CUsuario
    {

        MUsuario mUsuario = new MUsuario();

        public void Insertar(Usuarioss usuarioss)
        {
            mUsuario.Insertar(usuarioss);
        }

        public void Actualizar(Usuarioss usuarioss)
        {
            mUsuario.Actualizar(usuarioss);
        }

        public void Eliminar(Usuarioss usuarioss)
        {
            mUsuario.Eliminar(usuarioss);
        }

        public List<Usuarioss> Consultar()
        {
            return mUsuario.Consultar();
        }
    }
}