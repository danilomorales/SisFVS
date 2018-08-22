using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEComprobantePago
    {
        private int _Id_comp_pago { get; set; }
        private string _cod_sunat_comp_pago { get; set; }
        private string _des_comp_pago { get; set; }
        private string _des_comp_pago_breve { get; set; }
        private string _flg_comp_pago { get; set; }
        private int _ide_usuario { get; set; }
    }
}
