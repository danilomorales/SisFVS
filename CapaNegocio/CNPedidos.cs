using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class CNPedidos
    {
        private CDPedidos objDato = new CDPedidos();
        public SqlDataAdapter buscarPedidos(String fecha1,String fecha2)
        {
            return objDato.buscarPedido(fecha1,fecha2);
        }

        public SqlDataAdapter buscarDetallePedido(String idPedido)
        {
            return objDato.buscarDetallePedido(idPedido);
        }
    }
}
