using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CE_FE_Comprobante_Venta
    {
        Int64 ide_venta;

        public Int64 Ide_Venta
        {
            get { return ide_venta; }
            set { ide_venta = value; }
        }

        int ide_cliente;

        public int Ide_Cliente
        {
            get { return ide_cliente; }
            set { ide_cliente = value; }
        }

        int ide_comp_pago;

        public int Ide_Comp_Pago
        {
            get { return ide_comp_pago; }
            set { ide_comp_pago = value; }
        }

        string num_serie_venta;

        public string Num_Serie_Venta
        {
            get { return num_serie_venta; }
            set { num_serie_venta = value; }
        }

        string num_doc_venta;

        public string Num_Doc_Venta
        {
            get { return num_serie_venta; }
            set { num_serie_venta = value; }
        }

        DateTime fec_emite_venta;

        public DateTime Fec_Emite_Venta
        {
            get { return fec_emite_venta; }
            set { fec_emite_venta = value; }
        }

        string num_ruc_venta;

        public string Num_Ruc_Venta
        {
            get { return num_ruc_venta; }
            set { num_ruc_venta = value; }
        }

        int ide_empresa_fact;

        public int Ide_Empresa_Fact
        {
            get { return ide_empresa_fact; }
            set { ide_empresa_fact = value; }
        }

        string des_nombre_venta;

        public string Des_Nombre_Venta
        {
            get { return des_nombre_venta; }
            set { des_nombre_venta = value; }
        }

        string des_direc_venta;

        public string des_Direc_Venta
        {
            get { return des_direc_venta; }
            set { des_direc_venta = value; }
        }

        int ide_tipo_venta;
        public int Ide_Tipo_Venta
        {
            get { return ide_tipo_venta; }
            set { ide_tipo_venta = value; }
        }

        int can_dias_pago_venta;
        public int Can_Dias_Pago_Venta
        {
            get { return can_dias_pago_venta; }
            set { can_dias_pago_venta = value; }
        }

        DateTime fec_vmto_venta;
        public DateTime Fec_Vmto_Venta
        {
            get { return fec_vmto_venta; }
            set { fec_vmto_venta = value; }
        }

        int ide_motivo_notcred;
        public int Ide_Motivo_Notcred
        {
            get { return ide_motivo_notcred; }
            set { ide_motivo_notcred = value; }
        }

        string ref_num_serie_venta;
        public string Ref_Num_Serie_Venta
        {
            get { return ref_num_serie_venta; }
            set { ref_num_serie_venta = value; }
        }

        string ref_num_doc_venta;
        public string Ref_Num_Doc_Venta
        {
            get { return ref_num_doc_venta; }
            set { ref_num_doc_venta = value; }
        }

        Double imp_tipo_cambio_venta;
        public Double Imp_Tipo_Cambio_Venta
        {
            get { return imp_tipo_cambio_venta; }
            set { imp_tipo_cambio_venta = value; }
        }

        int ide_moneda;
        public int Ide_moneda
        {
            get { return ide_moneda; }
            set { ide_moneda = value; }
        }

        Double imp_valor_venta;
        public Double Imp_Valor_Venta
        {
            get { return imp_valor_venta; }
            set { imp_valor_venta = value; }
        }

        Double imp_depo_venta;
        public Double Imp_Depo_Venta
        {
            get { return imp_depo_venta; }
            set { imp_depo_venta = value; }
        }

        Double imp_total_venta;
        public Double Imp_Total_Venta
        {
            get { return imp_total_venta; }
            set { imp_total_venta = value; }
        }

        Double por_impto_venta;
        public Double Por_Impto_Venta
        {
            get { return por_impto_venta; }
            set { por_impto_venta = value; }
        }

        Double imp_impto_venta;
        public Double Imp_Impto_Venta
        {
            get { return imp_impto_venta; }
            set { imp_impto_venta = value; }
        }

        Double imp_precio_venta;
        public Double Imp_Precio_Venta
        {
            get { return imp_precio_venta; }
            set { imp_precio_venta = value; }
        }

        Double imp_val_inaf_venta;
        public Double Imp_Val_Inaf_Venta
        {
            get { return imp_val_inaf_venta; }
            set { imp_val_inaf_venta = value; }
        }

        Double imp_depo_inaf_venta;
        public Double Imp_Depo_Inaf_Venta
        {
            get { return imp_depo_inaf_venta; }
            set { imp_depo_inaf_venta = value; }
        }

        Double imp_precio_inaf_venta;
        public Double Imp_Precio_Inaf_Venta
        {
            get { return imp_precio_inaf_venta; }
            set { imp_precio_inaf_venta = value; }
        }

        Double imp_precio_total_venta;
        public Double Imp_Precio_Total_Venta
        {
            get { return imp_precio_inaf_venta; }
            set { imp_precio_inaf_venta = value; }
        }

        Double imp_paga_venta;
        public Double Imp_Paga_Venta
        {
            get { return imp_paga_venta; }
            set { imp_paga_venta = value; }
        }

        Double imp_saldo_venta;
        public Double Imp_Saldo_Venta
        {
            get { return imp_saldo_venta; }
            set { imp_saldo_venta = value; }
        }

        int ide_punto_venta;
        public int Ide_Punto_Venta
        {
            get { return ide_punto_venta; }
            set { ide_punto_venta = value; }
        }

        int ide_area;
        public int Ide_Area
        {
            get { return ide_area; }
            set { ide_area = value; }
        }

        int ide_estado_venta;
        public int Ide_Estado_Venta
        {
            get { return ide_estado_venta; }
            set { ide_estado_venta = value; }
        }

        int ide_usuario;
        public int Ide_Usuario
        {
            get { return ide_usuario; }
            set { ide_usuario = value; }
        }

        DateTime fec_ultima_act;
        public DateTime Fec_Ultima_Act
        {
            get { return fec_ultima_act; }
            set { fec_ultima_act = value; }
        }

        DateTime fec_factu_comp_venta;
        public DateTime Fec_Factu_Comp_Venta
        {
            get { return fec_factu_comp_venta; }
            set { fec_factu_comp_venta = value; }
        }

        int ide_motivo_anula_venta;
        public int Ide_Motivo_Anula_Venta
        {
            get { return ide_motivo_anula_venta; }
            set { ide_motivo_anula_venta = value; }
        }

        string des_obs_motivo_anula;
        public string Des_Obs_Motivo_Anula
        {
            get { return des_obs_motivo_anula; }
            set { des_obs_motivo_anula = value; }
        }

        int ide_sucursal;
        public int Ide_Sucursal
        {
            get { return ide_sucursal; }
            set { ide_sucursal = value; }
        }
    }
}
