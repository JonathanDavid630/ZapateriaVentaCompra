using ZapateriaVentaCompra.Entidades;
using ZapateriaVentaCompra.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaVentaCompra.Controladores
{
    public class CLinea
    {
        MEstilo mEstilo = new MEstilo();


        public void Insertar(Estiloss estiloss)
        {
            mEstilo.Insertar(estiloss); 
        }

        public void Actualizar(Estiloss estiloss)
        {
            mEstilo.Actualizar(estiloss);
        }

        public void Eliminar(Estiloss estiloss)
        {
            mEstilo.Eliminar(estiloss);
        }

        public List<Estiloss> Consultar()
        {
            return mEstilo.Consultar();
        }

        public Estiloss ConsultarUno(int id)
        {
            return mEstilo.ConsultarUno(id);
        }


    }
}
