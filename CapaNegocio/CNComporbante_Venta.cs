using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class CNComporbante_Venta
    {
        CDComprobante_Venta cv = new CDComprobante_Venta();

        //READALL COMPROBANTE_VENTA
        public SqlDataAdapter MostarComprobante_Venta()
        {
            return cv.listarComprobante_Venta();
        }
    }
}
