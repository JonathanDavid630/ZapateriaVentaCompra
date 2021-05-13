using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaVentaCompra.Entidades
{
    public class Usuarioss
    {
        private int idUsuarioss;

        public int IdUsuarioss
        {
            get { return idUsuarioss; }
            set { idUsuarioss = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int dui;

        public int Dui
        {
            get { return dui; }
            set { dui = value; }
        }

        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string clave;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        private int papels;

        public int IdPapels_Fk
        {
            get { return papels; }
            set { papels = value; }
        }


    }
}
