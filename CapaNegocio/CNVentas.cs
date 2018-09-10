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
       
        DataTable tabla = new DataTable();
        DataTable tabla2 = new DataTable();
        DataTable tabla3 = new DataTable();
        DataTable tabla4 = new DataTable();
        DataTable tabla5 = new DataTable();
        DataTable tabla6 = new DataTable();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public String RegistrarVenta()
        {
            String Mensaje = "";
            List<clParametro> lst = new List<clParametro>();
            try
            {
               
                return Mensaje = lst[7].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String traerCorrelativo(int opcion,int nserie)
        {
            String correlativo = "";
            SqlCommand comando = new SqlCommand("Caja.SP_TraerCorrelativo", C.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@vIde_Comp_Pago", opcion);
            comando.Parameters.AddWithValue("@IdSerie", nserie);
            comando.Parameters.Add("@Correlativo", SqlDbType.VarChar,10).Direction = ParameterDirection.Output;
            comando.ExecuteNonQuery();
            correlativo = comando.Parameters["@Correlativo"].Value.ToString();
            return correlativo;
        }

        public DataTable traerSerie(int opcion)
        {
            String correlativo = "";
            SqlCommand comando = new SqlCommand("Caja.SP_TraerNSerie", C.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@vIde_Comp_Pago", opcion);
            SqlDataReader lector = comando.ExecuteReader();
            tabla4.Load(lector);
            return tabla4;
        }

        public DataTable MostarCboTipoDoc()
        {
            comando.Connection = C.AbrirConexion();
            comando.CommandText = "select * from Caja.TIPO_DOC  WHERE Clasificacion='V'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            C.CerrarConexion();
            return tabla;
        }

        public DataTable MostarCboTipoTarjeta()
        {
            comando.Connection = C.AbrirConexion();
            comando.CommandText = "select * from Caja.TipoTarjeta ";
            leer = comando.ExecuteReader();
            tabla5.Load(leer);
            C.CerrarConexion();
            return tabla5;
        }

        public DataTable MostarCboTarjeta(int idTipoTarjeta)
        {
            comando.Connection = C.AbrirConexion();
            comando.CommandText = "select * from Caja.Tarjeta where IdTipoTarjeta=@IdTipoTarjeta";
            comando.Parameters.AddWithValue("@IdTipoTarjeta", idTipoTarjeta);
            leer = comando.ExecuteReader();
            tabla6.Load(leer);
            C.CerrarConexion();
            return tabla6;
        }

        public DataTable MostarCboTipoPago()
        {
            comando.Connection = C.AbrirConexion();
            comando.CommandText = "select * from Caja.TIPO_PAGO WHERE Estado='1'";
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

        public String traerTipoCambio(int idmoneda)
        {
            String tipocambio = "";
            SqlCommand comando = new SqlCommand("Caja.SP_FE_TraerTipoCambio", C.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdMoneda", idmoneda);
            SqlParameter param = new SqlParameter("@TCVenta", SqlDbType.Decimal);
            param.SourceColumn = "TCVenta";
            param.Precision = 10;
            param.Scale = 2;
            comando.Parameters.Add(param).Direction = ParameterDirection.Output;
            comando.ExecuteNonQuery();
            tipocambio = comando.Parameters["@TCVenta"].Value.ToString();
            return tipocambio;
        }


    }
}
