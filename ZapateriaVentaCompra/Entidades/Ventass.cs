using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaVentaCompra.Entidades
{
    public class Ventass
    {
        private int idVenta;

        public int IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string cliente;

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private int usuario;

        public int idUsuario_FK
        {
            get { return usuario; }
            set { usuario = value; }
        }


    }
}
