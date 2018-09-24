using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDCaja
    {
        private static readonly CDCaja _intancia = new CDCaja();
        public static CDCaja Instancia
        {
            get { return CDCaja._intancia; }
        }


        private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private SqlDataAdapter adapter;

        //Lista Caja
        public List<CECaja> ListaCajaApertura()
        {
            SqlCommand cmd = null;
            List<CECaja> Lista = null;
            SqlDataReader dr = null;
            
            try
            {
                SqlConnection cn = CDConexion.Instancia.AbrirConexion();
                cmd = new SqlCommand("Caja.SP_FE_ListaCaja", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                dr = cmd.ExecuteReader();
                Lista = new List<CECaja>();
                while (dr.Read())
                {

                    CECaja caja = new CECaja();

                    caja.Nombre = dr["Nombre_Caja"].ToString();
                    caja.Ingreso = Convert.ToDecimal(dr["MontoInicial"].ToString());
                    caja.Egreso = Convert.ToDecimal(dr["MontoFinal"].ToString());
                    caja.Cajero = dr["Cajero"].ToString();
                    caja.TipoOper = dr["Estado"].ToString();
                    caja.Voucher = dr["voucher"].ToString();
                    caja.FechaOperacion = dr["FechaOperacion"].ToString();

                    Lista.Add(caja);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        //Inserta Monto Voucher 
        public void InsertaCaja_Monto(string TipoOper,string IdSupervisor, string IdCajero, string tipodoc, string Ingreso, string Egreso, string voucher)
        {
            Console.Write("se insertó" + TipoOper + " " + IdSupervisor + " " + IdCajero + " " + tipodoc + " " + Ingreso + " " + Egreso + " " + voucher); comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Caja.SP_FE_InsertaCaja_Usuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TipoOper", TipoOper);
            comando.Parameters.AddWithValue("@IdSupervisor", IdSupervisor);
            comando.Parameters.AddWithValue("@Ingreso", Ingreso);
            comando.Parameters.AddWithValue("@Egreso", Egreso);
            comando.Parameters.AddWithValue("@voucher", voucher);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
    }
}
