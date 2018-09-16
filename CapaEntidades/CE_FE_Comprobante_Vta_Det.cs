using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CE_FE_Comprobante_Vta_Det
    {

        Int64 ide_venta;

        public Int64 Ide_Venta
        {
            get { return ide_venta; }
            set { ide_venta = value; }
        }

        int num_item_vta_det;

        public int Num_Item_Vta_Det
        {
            get { return num_item_vta_det; }
            set { num_item_vta_det = value; }
        }

        string ide_producto;

        public string Ide_Producto
        {
            get { return ide_producto; }
            set { ide_producto = value; }
        }

        string des_concepto_vta_det;

        public string Des_Concepto_Vta_Det
        {
            get { return des_concepto_vta_det; }
            set { des_concepto_vta_det = value; }
        }

        Double imp_unit_vta_det;

        public Double Imp_Unit_Vta_Det
        {
            get { return imp_unit_vta_det; }
            set { imp_unit_vta_det = value; }
        }

        Double can_unit_vta_det;

        public Double Can_Unit_Vta_Det
        {
            get { return can_unit_vta_det; }
            set { can_unit_vta_det = value; }
        }

        Double imp_costo_vta_det;

        public Double Imp_Costo_Vta_Det
        {
            get { return imp_costo_vta_det; }
            set { imp_costo_vta_det = value; }
        }

        Double por_dscto_vta_det;

        public Double Por_Dscto_Vta_Det
        {
            get { return por_dscto_vta_det; }
            set { por_dscto_vta_det = value; }
        }

        Double imp_dscto_vta_det;

        public Double Imp_Dscto_Vta_Det
        {
            get { return imp_dscto_vta_det; }
            set { imp_dscto_vta_det = value; }
        }

        Double imp_valor_vta_det;

        public Double Imp_Valor_Vta_Det
        {
            get { return imp_valor_vta_det; }
            set { imp_valor_vta_det = value; }
        }

        int flg_inaf_vta_det;

        public int Flg_Inaf_Vta_Det
        {
            get { return flg_inaf_vta_det; }
            set { flg_inaf_vta_det = value; }
        }

        Double por_impto_vta_det;

        public Double Por_Impto_Vta_Det
        {
            get { return por_impto_vta_det; }
            set { por_impto_vta_det = value; }
        }

        Double imp_impto_vta_det;

        public Double Imp_Impto_Vta_Det
        {
            get { return imp_impto_vta_det; }
            set { imp_impto_vta_det = value; }
        }

        Double imp_precio_vta_det;

        public Double Imp_Precio_Vta_Det
        {
            get { return imp_precio_vta_det; }
            set { imp_precio_vta_det = value; }
        }
    }
}
