using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    class CDVenta
    {
        private int _IdVenta;
        private int _IdCliente;
        private int _IdUsuario;
        private int _IdPersona;
        private int _IdResponsable;
        private int _IdTipoDoc;
        private int _IdTipoPago;
        private DateTime _FechaVenta;
        private string _Nota;
        private string _Serie;
        private float _IGV;

        public float IGV { get => _IGV; set => _IGV = value; }
        public string Serie { get => _Serie; set => _Serie = value; }
        public string Nota { get => _Nota; set => _Nota = value; }
        public DateTime FechaVenta { get => _FechaVenta; set => _FechaVenta = value; }
        public int IdTipoPago { get => _IdTipoPago; set => _IdTipoPago = value; }
        public int IdTipoDoc { get => _IdTipoDoc; set => _IdTipoDoc = value; }
        public int IdResponsable { get => _IdResponsable; set => _IdResponsable = value; }
        public int IdPersona { get => _IdPersona; set => _IdPersona = value; }
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public int IdVenta { get => _IdVenta; set => _IdVenta = value; }

        public CDVenta() { }

        //cons
        public CDVenta(int idventa, int idcliente, int idusuario, int idpersona, int idresponsable, int tipodoc, int idtipopago, DateTime fechaventa, string notita, string serie, float igv)
        {
            this.IdVenta = idventa;
            this.IdCliente = idcliente;
            this.IdUsuario = idusuario;
            this.IdPersona = idpersona;
            this.IdResponsable = idresponsable;
            this.IdTipoDoc = tipodoc;
            this.IdTipoPago = idtipopago;
            this.FechaVenta = fechaventa;
            this.Nota = notita;
            this.Serie = serie;
            this.IGV = igv;

        }




    }
}
