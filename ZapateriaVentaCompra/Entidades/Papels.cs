using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaVentaCompra.Entidades
{
    public class Papels
    {
        private int idPapels;
        public int IdPapels
        {
            get { return idPapels; }
            set { idPapels = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
            }
        }
        private string  descripcion;

        public string  Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
