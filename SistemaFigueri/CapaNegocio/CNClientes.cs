using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
   public class CNClientes
    {
        private CDCliente cli = new CDCliente();

        public DataTable MostarClientes()
        {
            DataTable table = new DataTable();
            table = cli.listarClientes();
            return table;
        }
    }
}
