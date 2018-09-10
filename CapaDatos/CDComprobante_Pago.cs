using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDComprobante_Pago
    {
        private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private SqlDataAdapter adapter;

        //LISTAR COMPRABANTE_PAGO
        public SqlDataAdapter listarComprobante_Pago()
        {
            String sql = "Caja.SP_FE_MostrarComprobante_Pago";
            adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
            return adapter;
        }

        //INSERTAR COMPRABANTE_PAGO
        public void InsertarComprobante_Pago(string cod_sunat, string des_comp, 
            string des_comp_breve, int idusu,string fecha)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Caja.SP_FE_InsertarComprobante_Pago";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod_sunat", cod_sunat);
            comando.Parameters.AddWithValue("@des_comp", des_comp);
            comando.Parameters.AddWithValue("@des_comp_breve", des_comp_breve);
            comando.Parameters.AddWithValue("@idusu", idusu);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //EDITAR COMPRABANTE_PAGO
        public void EditarComprobante_Pago(string cod_sunat, string des_comp, string des_comp_breve, 
            int idusu, string fecha, int idcomPago)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Caja.SP_FE_EditarComprobante_Pago";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod_sunat", cod_sunat);
            comando.Parameters.AddWithValue("@des_comp", des_comp);
            comando.Parameters.AddWithValue("@des_comp_breve", des_comp_breve);
            comando.Parameters.AddWithValue("@idusu", idusu);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@idcomPago", idcomPago);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //ElIMINAR COMPRABANTE_PAGO
        public void EliminarComprobante_Pago(int idcomPago)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Caja.SP_FE_EliminarComprobante_Pago";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idcomPago", idcomPago);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
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
