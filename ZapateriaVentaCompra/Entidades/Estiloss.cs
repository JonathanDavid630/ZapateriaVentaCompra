using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaVentaCompra.Entidades
{
    public class Estiloss
    {
        private int idEstilo;

        public int IdEstilo
        {
            get { return idEstilo; }
            set { idEstilo = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int talla;

        public int Talla
        {
            get { return talla; }
            set { talla = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

    }
}
