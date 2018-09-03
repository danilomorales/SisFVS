using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEDetalleVenta
    {
        private int _ide_venta;
        private int _num_item_vta_det;
        private string _ide_producto;
        private string _des_concepto_vta_det;
        private decimal _imp_unit_vta_det;
        private decimal _can_unit_vta_det;
        private decimal _imp_costo_vta_det;
        private decimal _por_dscto_vta_det;
        private decimal _imp_dscto_vta_det;
        private decimal _imp_valor_vta_det;
        private decimal _flg_inaf_vta_det;
        private decimal _por_impto_vta_det;
        private decimal _imp_precio_vta_det;

        //relaciones
        public CEVenta Venta { get; set; }

        public int Ide_venta { get => _ide_venta; set => _ide_venta = value; }
        public int Num_item_vta_det { get => _num_item_vta_det; set => _num_item_vta_det = value; }
        public string Ide_producto { get => _ide_producto; set => _ide_producto = value; }
        public string Des_concepto_vta_det { get => _des_concepto_vta_det; set => _des_concepto_vta_det = value; }
        public decimal Imp_unit_vta_det { get => _imp_unit_vta_det; set => _imp_unit_vta_det = value; }
        public decimal Can_unit_vta_det { get => _can_unit_vta_det; set => _can_unit_vta_det = value; }
        public decimal Imp_costo_vta_det { get => _imp_costo_vta_det; set => _imp_costo_vta_det = value; }
        public decimal Por_dscto_vta_det { get => _por_dscto_vta_det; set => _por_dscto_vta_det = value; }
        public decimal Imp_dscto_vta_det { get => _imp_dscto_vta_det; set => _imp_dscto_vta_det = value; }
        public decimal Imp_valor_vta_det { get => _imp_valor_vta_det; set => _imp_valor_vta_det = value; }
        public decimal Flg_inaf_vta_det { get => _flg_inaf_vta_det; set => _flg_inaf_vta_det = value; }
        public decimal Por_impto_vta_det { get => _por_impto_vta_det; set => _por_impto_vta_det = value; }
        public decimal Imp_precio_vta_det { get => _imp_precio_vta_det; set => _imp_precio_vta_det = value; }

    }
}
