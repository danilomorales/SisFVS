using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNVentas
    {
        CDConexion C = new CDConexion();
        public int IdUsuario { get; set; }
        public int IdClienteReceptor { get; set; }
        public string Serie { get; set; }

    }
}
