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
    public class MProducto
    {
        IDbConnection cn = Conexion.conectar();

        public void Insertar(Producto producto)
        {
            string consulta = "Insert into Producto values(@nombre,@precio,@existencias,@idEstilo)";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", producto.Nombre, DbType.String);
            parametros.Add("@precio", producto.Precio, DbType.Decimal);
            parametros.Add("@existencias", producto.Existencias, DbType.Int32);
            parametros.Add("@idEstilo", producto.IdEstilo_FK, DbType.Int32);

            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public void Actualizar(Producto producto)
        {


            string consulta = "Update Producto set nombre=@nombre,precio=@precio,existencias=@existencias,IdEstilo_FK=@idEstilo where IdProducto=@idproducto";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", producto.Nombre, DbType.String);
            parametros.Add("@precio", producto.Precio, DbType.Decimal);
            parametros.Add("@existencias", producto.Existencias, DbType.Int32);
            parametros.Add("@idEstilo", producto.IdEstilo_FK, DbType.Int32);
            parametros.Add("@idproducto", producto.IdProducto, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }

        public void Eliminar(Producto producto)
        {
            string consulta = "Delete from Producto where IdProducto=@idproducto";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idproducto", producto.IdProducto, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Producto> Consultar()
        {
            List<Producto> productos = new List<Producto>();
            string consulta = "Select * from Producto";
            cn.Open();
            productos = cn.Query<Producto>(consulta).ToList();
            cn.Close();
            return productos;
        }

        public Producto ConsultarUno(int id)
        {
            string consulta = "Select * from Producto where IdProducto=@idproducto";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idproducto", id, DbType.Int32);
            cn.Open();
            Producto producto = cn.QuerySingle<Producto>(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
            return producto;
        }
    }
}
