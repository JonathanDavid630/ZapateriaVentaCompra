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
    public class MVentas
    {
        IDbConnection cn = Conexion.conectar();

        public void GuardarVenta(List<DetallesVentas> listado)
        {
            string consulta = "";
            DynamicParameters parametros = new DynamicParameters();

            foreach (var listVenta in listado)
            {
                consulta = "Insert into Ventass values(@fecha,@cliente)";

                parametros.Add("@fecha", DateTime.Now, DbType.DateTime);
                parametros.Add("@cliente", listVenta.Ventass.Cliente, DbType.String);

                cn.Open();
                cn.Execute(consulta, parametros, commandType: CommandType.Text);
                cn.Close();
            }

            consulta = "Select max(idventa) id from Ventass";
            cn.Open();
            int idventa = cn.QuerySingle<int>(consulta);
            cn.Close();


            foreach (DetallesVentas detalle in listado)
            {
                consulta = "Insert into DetallesVentas values(@cantidad,@precio,@idproducto,@idcompra)";
                parametros = new DynamicParameters();
                parametros.Add("@cantidad", detalle.Cantidad, DbType.Int32);
                parametros.Add("@precio", detalle.Precio, DbType.Decimal);
                parametros.Add("@idproducto", detalle.Producto.IdProducto, DbType.Int32);
                parametros.Add("@idcompra", idventa, DbType.Int32);
                cn.Open();
                cn.Execute(consulta, parametros, commandType: CommandType.Text);
                cn.Close();
            }
        }
    }
}