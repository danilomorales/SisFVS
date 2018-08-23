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
        private int cant_dias_pago { get; set; }
        private DateTime fecha_vmto { get; set; }
        //EN CASO DE SER NOTA DE CRÉDITO
        private String motivo_nc { get; set; }
        private String ref_nserie_nc { get; set; }
        private decimal ref_ndoc_nc { get; set; }
        private int idmoneda { get; set; }
        private decimal valor_venta { get; set; }
        private decimal deposito_venta { get; set; }
        private decimal importe_venta { get; set; }
        private decimal porc_igv { get; set; }
        private decimal igv_total { get; set; }
        //CUANTO PAGA EL CLIENTE
        private decimal impuesto_pago { get; set; }
        //CUANTO QUEDA DE SALDO
        private decimal importe_saldo { get; set; }
        private int id_punto_venta { get; set; }
        private int idarea { get; set; }
        //ESTADO DE COMPROBANTE
        private int id_est_venta { get; set; }
        private int idusuario { get; set; }
        private DateTime ultima_act{ get; set; }
        private String motivo_anulacion { get; set; }
        private int idsucursal { get; set; }

        
    }
}
