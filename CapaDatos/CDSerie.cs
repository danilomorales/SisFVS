using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDSerie
    {
        private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private SqlDataAdapter adapter;

        //LISTAR SERIE
        public SqlDataAdapter listarSerie()
        {
            String sql = "Caja.SP_FE_MostrarSerie";
            adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
            return adapter;
        }

        //INSERTAR SERIE
        public void InsertarSerie(string numeroserie, int fcorrelativo,int bcorrelativo, int nccorrelativo,
            int nccorrelativoBo, int nccorrelativoFac)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Caja.SP_FE_InsertarSerie";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@numeroserie", numeroserie);
            comando.Parameters.AddWithValue("@fcorrelativo", fcorrelativo);
            comando.Parameters.AddWithValue("@bcorrelativo", bcorrelativo);
            comando.Parameters.AddWithValue("@nccorrelativo", nccorrelativo);
            comando.Parameters.AddWithValue("@nccorrelativoBo", nccorrelativoBo);
            comando.Parameters.AddWithValue("@nccorrelativoFac", nccorrelativoFac);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //EDITAR SERIE
        public void EditarSerie(string numeroserie, int fcorrelativo, int bcorrelativo, int nccorrelativo,
            int nccorrelativoBo, int nccorrelativoFac,int idSerie)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Caja.SP_FE_EditarSerie";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@numeroserie", numeroserie);
            comando.Parameters.AddWithValue("@fcorrelativo", fcorrelativo);
            comando.Parameters.AddWithValue("@bcorrelativo", bcorrelativo);
            comando.Parameters.AddWithValue("@nccorrelativo", nccorrelativo);
            comando.Parameters.AddWithValue("@nccorrelativoBo", nccorrelativoBo);
            comando.Parameters.AddWithValue("@nccorrelativoFac", nccorrelativoFac);
            comando.Parameters.AddWithValue("@idSerie", idSerie);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //ELIMINAR SERIE
        public void EliminarSerie(int idSerie)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Caja.SP_FE_EliminarSerie";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idSerie", idSerie);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
