using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaDatos;
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
        private SqlDataReader leer;

        public String GenerarIdVenta()
        {
            List<clParametro> lst = new List<clParametro>();
            int objIdVenta;
            try
            {
                lst.Add(new clParametro("@IdVenta", "", SqlDbType.Int, ParameterDirection.Output, 4));
                C.EjecutarSP("SP_GenerarIdVenta", ref lst);
                objIdVenta = Convert.ToInt32(lst[0].Valor.ToString());  
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToString(objIdVenta);
        }
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
                C.EjecutarSP("Caja.SP_RegistraVenta", ref lst);
                return Mensaje = lst[7].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String traerSerie(int ide_comp)
        {
            String resultado = "";
            SqlCommand comando = new SqlCommand("Caja.SP_TraerNSerie", C.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@vIde_Comp_Pago", ide_comp);
            comando.Parameters.AddWithValue("@num_serie_venta", "001");
            comando.Parameters.Add("@Correlativo",SqlDbType.VarChar,10).Direction= ParameterDirection.Output;
            comando.ExecuteNonQuery();
            resultado = comando.Parameters["@Correlativo"].Value.ToString();
            return resultado;
        }



    }
}
