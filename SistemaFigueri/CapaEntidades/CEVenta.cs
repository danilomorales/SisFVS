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
        private double ref_ndoc_nc;
        private int idmoneda;
        private double valor_venta;
        private double deposito_venta;
        private double importe_venta;
        private double porc_igv;
        private double igv_total;
        //CUANTO PAGA EL CLIENTE
        private double impuesto_pago;
        //CUANTO QUEDA DE SALDO
        private double importe_saldo;
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
