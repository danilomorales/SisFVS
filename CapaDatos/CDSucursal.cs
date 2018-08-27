using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDSucursal
    {
        private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private SqlDataAdapter adapter;

        //LISTAR SUCURSAL
        public SqlDataAdapter listarSucursal()
        {
            String sql = "MostrarSucursal";
            adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
            return adapter;
        }

        //INSERTAR SUCURSAL
        public void InsertarSucursal(string nombe_sucu, string fecha_registro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarSucursal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombe_sucu", nombe_sucu);
            comando.Parameters.AddWithValue("@fecha_registro", fecha_registro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //EDITAR SUCURSAL
        public void EditarSucursal(string nombe_sucu, string fecha_registro,int idSucu)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarSucursal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombe_sucu", nombe_sucu);
            comando.Parameters.AddWithValue("@fecha_registro", fecha_registro);
            comando.Parameters.AddWithValue("@idSucu", idSucu);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //ELIMINAR SUCURSAL
        public void EliminarSucursal(int idSucu)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarSucursal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idSucu", idSucu);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        //LISTAR TIENDA
        public SqlDataAdapter listarTienda()
        {
            String sql = "MostrarTienda";
            adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
            return adapter;
        }

        //INSERTAR TIENDA
        public void InsertarTienda(string idResponsable, string nombreTienda,string direccion,string telefono,int serie,int ideSucursal)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarTienda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idResponsable", idResponsable);
            comando.Parameters.AddWithValue("@nombreTienda", nombreTienda);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@serie", serie);
            comando.Parameters.AddWithValue("@ideSucursal", ideSucursal);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //EDITAR TIENDA
        public void EditarTienda(string idResponsable, string nombreTienda, string direccion, string telefono, int serie, int ideSucursal, string idTienda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarTienda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idResponsable", idResponsable);
            comando.Parameters.AddWithValue("@nombreTienda", nombreTienda);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@serie", serie);
            comando.Parameters.AddWithValue("@ideSucursal", ideSucursal);
            comando.Parameters.AddWithValue("@idTienda", idTienda);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        //ELIMINAR TIENDA
        public void EliminarTienda(string idTienda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarTienda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idTienda", idTienda);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        //Llenar ComboBox SUCURSAL
        public DataTable ListarSucursal()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from caja.FE_SUCURSAL";
            leer = comando.ExecuteReader();
            table.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return table;
        }

        //Llenar ComboBox ENCARGADO
        public DataTable ListarEncargado()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from dbo.RESPONSABLE";
            leer = comando.ExecuteReader();
            table.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return table;
        }

        //LISTAR SECTOR
        public SqlDataAdapter listarSector()
        {
            String sql = "MostrarSector";
            adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
            return adapter;
        }

        //INSERTAR SECTOR
        public void InsertarSector(string descripcion, string nota, string idTienda, double porcentaje)
        {
            Console.Write("Se inserto SECTOR CD:" + descripcion + " " + nota + "  " + idTienda + "  " + porcentaje);
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarSector";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@nota", nota);
            comando.Parameters.AddWithValue("@idTienda", idTienda);
            comando.Parameters.AddWithValue("@porcentaje", porcentaje);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //EDITAR SECTOR
        public void EditarSector(string descripcion, string nota, string idTienda, double porcentaje,string idSector)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarSector";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@nota", nota);
            comando.Parameters.AddWithValue("@idTienda", idTienda);
            comando.Parameters.AddWithValue("@porcentaje", porcentaje);
            comando.Parameters.AddWithValue("@idSector", idSector);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //ELIMINAR TIENDA
        public void EliminarSector(string idSector)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarSector";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idSector", idSector);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        //Llenar ComboBox TIENDA
        public DataTable ListarTienda()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from dbo.TIENDA";
            leer = comando.ExecuteReader();
            table.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return table;
        }

        //LISTAR PUNTO_VENTA
        public SqlDataAdapter listarPunto_Venta()
        {
            String sql = "MostrarPunto_de_Venta";
            adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
            return adapter;
        }

        //INSERTAR PUNTO_VENTA
        public void InsertarPunto_Venta(string des_puntoVenta, int ide, string idSector, int flg_puntoVenta,int idUsu,string fecha)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarPunto_Venta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@des_puntoVenta", des_puntoVenta);
            comando.Parameters.AddWithValue("@ide", ide);
            comando.Parameters.AddWithValue("@idSector", idSector);
            comando.Parameters.AddWithValue("@flg_puntoVenta", flg_puntoVenta);
            comando.Parameters.AddWithValue("@idUsu", idUsu);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //EDITAR PUNTO_VENTA
        public void EditarPunto_Venta(string des_puntoVenta, int ide, string idSector, int flg_puntoVenta, int idUsu, string fecha,int idpunto_venta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarPunto_Venta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@des_puntoVenta", des_puntoVenta);
            comando.Parameters.AddWithValue("@ide", ide);
            comando.Parameters.AddWithValue("@idSector", idSector);
            comando.Parameters.AddWithValue("@flg_puntoVenta", flg_puntoVenta);
            comando.Parameters.AddWithValue("@idUsu", idUsu);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@idpunto_venta", idpunto_venta);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //ELIMINAR PUNTO_VENTA
        public void EliminarPunto_Venta(int idpunto_venta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarPunto_Venta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idpunto_venta", idpunto_venta);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        //Llenar ComboBox SECTOR
        public DataTable ListarSector()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from dbo.SECTOR";
            leer = comando.ExecuteReader();
            table.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return table;
        }

        //Llenar ComboBox USUARIO
        public DataTable ListarUsuario()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from caja.Usuario";
            leer = comando.ExecuteReader();
            table.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return table;
        }
    }
}
