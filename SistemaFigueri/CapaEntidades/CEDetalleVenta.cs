using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEDetalleVenta
    {
        private int _ide_venta { get; set; }
        private int _num_item_vta_det { get; set; }
        private string _ide_producto { get; set; }
        private string _des_concepto_vta_det { get; set; }
        private decimal _imp_unit_vta_det { get; set; }
        private decimal _can_unit_vta_det { get; set; }
        private decimal _imp_costo_vta_det { get; set; }
        private decimal _por_dscto_vta_det { get; set; }
        private decimal _imp_dscto_vta_det { get; set; }
        private decimal _imp_valor_vta_det { get; set; }
        private decimal _flg_inaf_vta_det { get; set; }
        private decimal _por_impto_vta_det { get; set; }
        private decimal _imp_precio_vta_det { get; set; }

        //relaciones
        public CEVenta Venta { get; set; }
    }
}
