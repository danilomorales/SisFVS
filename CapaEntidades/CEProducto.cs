using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEProducto
    {
        public int _IdProdcuto { get; set; }
        public String _Codigo { get; set; }
        public String _Alias { get; set; }
        public String _DescripcionProducto { get; set; }
        public string _TiempoDuracion { get; set; }
        public string _Stock { get; set; }
        public double _precio { get; set; }
        public int _Cantidad { get; set; }
        public String _CodBarra { get; set; }

    }
}
