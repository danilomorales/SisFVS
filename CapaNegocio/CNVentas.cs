using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;
using CapaDatos;
using System.Data.SqlClient;
using System.Data.Sql;

namespace CapaNegocio
{
    public class CNVentas
    {
        CDConexion C = new CDConexion();
        public int IdUsuario { get; set; }
        public int IdClienteReceptor { get; set; }
        public int IdSerie { get; set; }
        public int IdTipoDoc { get; set; }
        public int NroDocumento { get; set; }
        public DateTime Fecha_Venta { get; set; }
        public decimal Total { get; set; }
        DataTable tabla = new DataTable();
        DataTable tabla2 = new DataTable();
        DataTable tabla3 = new DataTable();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public String RegistrarVenta()
        {
            String Mensaje = "";
            List<clParametro> lst = new List<clParametro>();
            try
            {
                lst.Add(new clParametro("@IdUsuario", IdUsuario));
                lst.Add(new clParametro("@IdClienteReceptor", IdClienteReceptor));
                lst.Add(new clParametro("@IdSerie", IdSerie));
                lst.Add(new clParametro("@IdTipoDoc", IdTipoDoc));
                lst.Add(new clParametro("@NroDocumento", NroDocumento));
                lst.Add(new clParametro("@Fecha_Venta", Fecha_Venta));
                lst.Add(new clParametro("@Total", Total));
                lst.Add(new clParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
               // C.EjecutarSP("Caja.SP_RegistraVenta", ref lst);
                return Mensaje = lst[7].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String traerCorrelativo(int opcion)
        {
            String correlativo = "";
            SqlCommand comando = new SqlCommand("Caja.SP_TraerCorrelativo", C.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@vIde_Comp_Pago", opcion);
            comando.Parameters.AddWithValue("@num_serie_venta", "001");
            comando.Parameters.Add("@Correlativo", SqlDbType.VarChar,10).Direction = ParameterDirection.Output;
            comando.ExecuteNonQuery();
            correlativo = comando.Parameters["@Correlativo"].Value.ToString();
            return correlativo;
        }

        public DataTable MostarCboTipoDoc()
        {
            comando.Connection = C.AbrirConexion();
            comando.CommandText = "select * from dbo.TIPO_DOC  WHERE Clasificacion='V'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            C.CerrarConexion();
            return tabla;
        }

        public DataTable MostarCboTipoPago()
        {
            comando.Connection = C.AbrirConexion();
            comando.CommandText = "select * from dbo.TIPO_PAGO";
            SqlDataReader lector = comando.ExecuteReader();
            tabla2.Load(lector);
            C.CerrarConexion();
            return tabla2;
        }

        public DataTable MostarCboMoneda()
        {
            comando.Connection = C.AbrirConexion();
            comando.CommandText = "select * from Caja.Moneda";
            SqlDataReader lector = comando.ExecuteReader();
            tabla3.Load(lector);
            C.CerrarConexion();
            return tabla3;
        }



    }
}
