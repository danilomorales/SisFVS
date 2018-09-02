using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEVenta
    {
        private int idventa;
        private int idcomprobante;
        private String nserie;
        private double ndoc_venta;
        private DateTime fecha_emision;
        private String ruc_venta;
        private String descripcion;
        private String direccion;
        private int cant_dias_pago;
        private DateTime fecha_vmto;
        //EN CASO DE SER NOTA DE CRÉDITO
        private String motivo_nc;
        private String ref_nserie_nc;
        private decimal ref_ndoc_nc;
        private int idmoneda;
        private decimal valor_venta;
        private decimal deposito_venta;
        private decimal importe_venta;
        private decimal porc_igv;
        private decimal igv_tota;


        public int Idventa { get => idventa; set => idventa = value; }
        public int Idcomprobante { get => idcomprobante; set => idcomprobante = value; }
        public string Nserie { get => nserie; set => nserie = value; }
        public double Ndoc_venta { get => ndoc_venta; set => ndoc_venta = value; }
        public DateTime Fecha_emision { get => fecha_emision; set => fecha_emision = value; }
        public string Ruc_venta { get => ruc_venta; set => ruc_venta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Cant_dias_pago { get => cant_dias_pago; set => cant_dias_pago = value; }
        public DateTime Fecha_vmto { get => fecha_vmto; set => fecha_vmto = value; }
        //nota de venta
        public string Motivo_nc { get => motivo_nc; set => motivo_nc = value; }
        public string Ref_nserie_nc { get => ref_nserie_nc; set => ref_nserie_nc = value; }
        public decimal Ref_ndoc_nc { get => ref_ndoc_nc; set => ref_ndoc_nc = value; }
        public int Idmoneda { get => idmoneda; set => idmoneda = value; }
        public decimal Valor_venta { get => valor_venta; set => valor_venta = value; }
        public decimal Deposito_venta { get => deposito_venta; set => deposito_venta = value; }
        public decimal Importe_venta { get => importe_venta; set => importe_venta = value; }
        public decimal Porc_igv { get => porc_igv; set => porc_igv = value; }
        public decimal Igv_tota { get => igv_tota; set => igv_tota = value; }
        //CUANTO PAGA EL CLIENTE
        public decimal Impuesto_pago { get => impuesto_pago; set => impuesto_pago = value; }
        //CUANTO QUEDA DE SAldo
        public decimal Importe_saldo { get => importe_saldo; set => importe_saldo = value; }
        public int Id_punto_venta { get => id_punto_venta; set => id_punto_venta = value; }
        public int Idarea { get => idarea; set => idarea = value; }

        //estado de comprbante
        public int Id_est_venta { get => id_est_venta; set => id_est_venta = value; }
        public int Idusuario { get => idusuario; set => idusuario = value; }
        public DateTime Ultima_act { get => ultima_act; set => ultima_act = value; }
        public string Motivo_anulacion { get => motivo_anulacion; set => motivo_anulacion = value; }
        public int Idsucursal { get => idsucursal; set => idsucursal = value; }

        //CUANTO PAGA EL CLIENTE
        private decimal impuesto_pago;
        //CUANTO QUEDA DE SALDO
        private decimal importe_saldo;
        private int id_punto_venta;
        private int idarea;
        //ESTADO DE COMPROBANTE
        private int id_est_venta;
        private int idusuario;
        private DateTime ultima_act;
        private String motivo_anulacion;
        private int idsucursal;


    }
}
