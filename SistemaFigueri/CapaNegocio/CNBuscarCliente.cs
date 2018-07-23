using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
   public class CNBuscarCliente
    {
        private CDBusqueda objCD = new CDBusqueda();
        public DataTable MostrarResultadoCliente()
        {
            DataTable table = new DataTable();
            table = objCD.MostrarResultado();
            return table;
        }

        


        //comando.Parameters.Add("@filtro", SqlDbType.VarChar, 50).Value = MostrarResultado;


   }
}
