using ZapateriaVentaCompra.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ZapateriaVentaCompra.Modelos
{
    public class MCompra
    {
        IDbConnection cn = Conexion.conectar();

        public void GuardarCompra(List<DetallesCompras> listado)
        {
            string consulta = "Insert into compras values(@fecha,@estado)";

            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@fecha", DateTime.Now, DbType.DateTime);
            parametros.Add("@estado", 1, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

            consulta = "Select max(idcompra) id from Compra";
            cn.Open();
            int idcompra = cn.QuerySingle<int>(consulta);
            cn.Close();


            foreach (DetallesCompras detalle in listado)
            {
                consulta = "Insert into DetallesCompras values(@cantidad,@precio,@idproducto,@idcompra)";
                parametros = new DynamicParameters();
                parametros.Add("@cantidad", detalle.Cantidad, DbType.Int32);
                parametros.Add("@precio", detalle.Precio, DbType.Decimal);
                parametros.Add("@idproducto", detalle.Producto.IdProducto, DbType.Int32);
                parametros.Add("@idcompra", idcompra, DbType.Int32);
                cn.Open();
                cn.Execute(consulta, parametros, commandType: CommandType.Text);
                cn.Close();
            }
        }
    }
}
