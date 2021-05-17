using System;
using ZapateriaVentaCompra.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;


namespace ZapateriaVentaCompra.Modelos
{
    public class MUsuario
    {
        IDbConnection cn = Conexion.conectar();

        public void Insertar(Usuarioss usuarioss)
        { //4- Se recibe del controlador
            //**********
            string consulta = "Insert into Usuarios values(@nombre,@dui,@direccion,@telefono,@email,@rol,)";
            //**********
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", usuarioss.Nombre, DbType.String);
            parametros.Add("@dui", usuarioss.Dui, DbType.Int32);
            parametros.Add("@direccion", usuarioss.Direccion, DbType.Int32);
            parametros.Add("@telefono", usuarioss.Telefono, DbType.Int32);
            parametros.Add("@email", usuarioss.Email, DbType.Int32);
            parametros.Add("@rol", usuarioss.Rol, DbType.Int32);


            //**********
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }
        public void Actualizar(Usuarioss usuarioss)
        {
            string consulta = "Update Usuarioss set nombre + set dui + set direccion + telefono + email + rol ='" + usuarioss.Nombre + usuarioss.Dui + usuarioss.Direccion + usuarioss.Telefono + usuarioss.Email + usuarioss.Rol + "' where IdUsuario=" + usuarioss.IdUsuarioss; //corregir si da problema
            cn.Open();
            cn.Execute(consulta);
            cn.Close();
        }
        public void Eliminar(Usuarioss usuarioss)
        {
            string consulta = "Delete from Usuarios where idUsuarioss=" + usuarioss.IdUsuarioss;
            cn.Open();
            cn.Execute(consulta);
            cn.Close();
        }

        public List<Usuarioss> Consultar()
        {
            // Select * from lineas
            List<Usuarioss> usuariosses = new List<Usuarioss>();
            string consulta = "Select * from Usuarios";
            cn.Open();
            usuariosses = cn.Query<Usuarioss>(consulta).ToList();
            cn.Close();
            return usuariosses;
        }

        public Usuarioss ConsultarUno(int id)
        {
            string consulta = "Select * from Usuarios where idUsuarioss=" + id;
            cn.Open();
            // retornando un solo objeto
            Usuarioss usuarioss = cn.QuerySingle<Usuarioss>(consulta);
            cn.Close();
            return usuarioss;
        }
    }
}
