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
    public class CNKardex
    {
        private CDKardex car = new CDKardex();

        public DataTable MostarKardex(String idProducto)
        {
            DataTable table = new DataTable();
            table = car.listarKardex(idProducto);
            return table;
        }
    }
}
