using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDComprobante_Venta
    {
        private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private SqlDataAdapter adapter;

        //LISTAR COMPRABANTE_VENTA
        public SqlDataAdapter listarComprobante_Venta()
        {
            String sql = "Caja.SP_FE_MostrarComprobante_Ventas";
            adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
            return adapter;
        }
    }
}
