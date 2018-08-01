using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class CDDetalleVenta
    {

        private String _IdPedido;
        private String _IdTienda;
        private String _IdProducto;
        private String _Descripcion;
        private decimal _Valor;
        private decimal _Cantidad;
        private decimal _Enviados;
        private decimal _Devolucion;
        private decimal _Malogrados;
        private decimal _Total ;
        private decimal _Costo ;
        private decimal _Stock_Actual ;
        private decimal _Item;

        public decimal Item { get => _Item; set => _Item = value; }
        public decimal Stock_Actual { get => _Stock_Actual; set => _Stock_Actual = value; }
        public decimal Costo { get => _Costo; set => _Costo = value; }
        public decimal Total { get => _Total; set => _Total = value; }
        public decimal Malogrados { get => _Malogrados; set => _Malogrados = value; }
        public decimal Devolucion { get => _Devolucion; set => _Devolucion = value; }
        public decimal Enviados { get => _Enviados; set => _Enviados = value; }
        public decimal Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public decimal Valor { get => _Valor; set => _Valor = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public string IdTienda { get => _IdTienda; set => _IdTienda = value; }
        public string IdPedido { get => _IdPedido; set => _IdPedido = value; }
    }
}
