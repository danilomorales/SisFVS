using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEVenta
    {

        private int ide_cliente;

        public int _ide_cliente
        {
            get { return ide_cliente; }
            set { ide_cliente = value; }
        }
        private int cant_dias_pago;
        public int _cant_dias_pago
        {
            get { return cant_dias_pago; }
            set { cant_dias_pago = value; }
        }
        private DateTime fecha_vmto;
        public DateTime _fecha_vmto
        {
            get { return fecha_vmto; }
            set { fecha_vmto = value; }
        }
        //EN CASO DE SER NOTA DE CRÉDITO
        private String motivo_nc;
        public String _motivo_nc
        {
            get { return motivo_nc; }
            set { motivo_nc = value; }
        }

        private String ref_nserie_nc;
        private decimal ref_ndoc_nc;
        private int idmoneda;
        private decimal valor_venta;
        private decimal deposito_venta;
        private decimal importe_venta;
        private decimal porc_igv;
        private decimal igv_tota;

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

        public string Ref_nserie_nc { get => ref_nserie_nc; set => ref_nserie_nc = value; }
        public decimal Ref_ndoc_nc { get => ref_ndoc_nc; set => ref_ndoc_nc = value; }
        public int Idmoneda { get => idmoneda; set => idmoneda = value; }
        public decimal Valor_venta { get => valor_venta; set => valor_venta = value; }
        public decimal Deposito_venta { get => deposito_venta; set => deposito_venta = value; }
        public decimal Importe_venta { get => importe_venta; set => importe_venta = value; }
        public decimal Porc_igv { get => porc_igv; set => porc_igv = value; }
        public decimal Igv_tota { get => igv_tota; set => igv_tota = value; }
        public decimal Impuesto_pago { get => impuesto_pago; set => impuesto_pago = value; }
        public decimal Importe_saldo { get => importe_saldo; set => importe_saldo = value; }
        public int Id_punto_venta { get => id_punto_venta; set => id_punto_venta = value; }
        public int Idarea { get => idarea; set => idarea = value; }
        public int Id_est_venta { get => id_est_venta; set => id_est_venta = value; }
        public int Idusuario { get => idusuario; set => idusuario = value; }
        public DateTime Ultima_act { get => ultima_act; set => ultima_act = value; }
        public string Motivo_anulacion { get => motivo_anulacion; set => motivo_anulacion = value; }
        public int Idsucursal { get => idsucursal; set => idsucursal = value; }
    }
}
