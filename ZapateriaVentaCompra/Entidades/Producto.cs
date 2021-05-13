using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaVentaCompra.Entidades
{
    public class Producto
    {
        private int idProducto;

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        private int idEstilo_FK;

        public int IdEstilo_FK
        {
            get { return idEstilo_FK; }
            set { idEstilo_FK = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private int existencias;

        public int Existencias
        {
            get { return existencias; }
            set { existencias = value; }
        }

        private Estiloss estiloss;

        public Estiloss Estiloss
        {
            get { return estiloss; }
            set { estiloss = value; }
        }

        private Usuarioss usuarioss;

        public Usuarioss Usuarioss
        {
            get { return usuarioss; }
            set { usuarioss = value; }
        }

    }
}
