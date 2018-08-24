using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEComprovante_Venta_Pago
    {
        private int _ide_venta { get; set; }
        private int _num_item_venta_pago { get; set; }
        private int _ide_forma_pago { get; set; }
        private int _ide_tarjeta_banco { get; set; }
        private int _ide_banco { get; set; }
        private int _ide_banco_cuenta { get; set; }
        private string num_doc_pago { get; set; }
        private int _ide_moneda { get; set; }
        private decimal _imp_pago { get; set; }
        private decimal _ide_usuario { get; set; }


    }
}
