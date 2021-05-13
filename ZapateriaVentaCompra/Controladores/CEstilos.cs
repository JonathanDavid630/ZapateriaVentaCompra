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
        // Referencia al modelo
        MEstilo mEstilo = new MEstilo();


        public void Insertar(Estiloss estiloss) //2 - Se recibe de la vista
        {
            mEstilo.Insertar(estiloss); // 3-  Se envía al modelo
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
