using ZapateriaVentaCompra.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaVentaCompra.Modelos
{
    public class MEstilo
    {

        IDbConnection cn = Conexion.conectar();


        public void Insertar(Estiloss estiloss)
        { //4- Se recibe del controlador
            //****************************
            string consulta = "Insert into Estiloss values(@nombre)";
            //****************************
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", estiloss.Nombre, DbType.String);
            //****************************
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }
        public void Actualizar(Estiloss estiloss)
        {
            string consulta = "Update Estiloss set nombre='" + estiloss.Nombre + "' where IdEstilo=" + estiloss.IdEstilo;
            cn.Open();
            cn.Execute(consulta);
            cn.Close();
        }
        public void Eliminar(Estiloss estiloss)
        {
            string consulta = "Delete from Estiloss where idEstilo=" + estiloss.IdEstilo;
            cn.Open();
            cn.Execute(consulta);
            cn.Close();
        }

        public List<Estiloss> Consultar()
        {
            // Select * from lineas
            List<Estiloss> estilosses = new List<Estiloss>();
            string consulta = "Select * from Estiloss";
            cn.Open();
            estilosses = cn.Query<Estiloss>(consulta).ToList();
            cn.Close();
            return estilosses;
        }

        public Estiloss ConsultarUno(int id)
        {
            string consulta = "Select * from lineas where IdEstilo=" + id;
            cn.Open();
            // retornando un solo objeto
            Estiloss estiloss = cn.QuerySingle<Estiloss>(consulta);
            cn.Close();
            return estiloss;
        }

    }
}