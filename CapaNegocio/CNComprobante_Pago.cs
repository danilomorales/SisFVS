using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CNComprobante_Pago
    {
        CDComprobante_Pago cdcompro = new CDComprobante_Pago();

        //READALL COMPROBANTE_PAGO
        public SqlDataAdapter MostarComprobante_Pago()
        {
            return cdcompro.listarComprobante_Pago();
        }

        //INSERT COMPROBANTE_PAGO
        public void InsertComprobante_Pago(string cod_sunat, string des_comp,
            string des_comp_breve, string idusu, string fecha)
        {
            cdcompro.InsertarComprobante_Pago(cod_sunat,des_comp,des_comp_breve,Convert.ToInt32(idusu),fecha);
        }

        //UPDATE COMPROBANTE_PAGO
        public void UpdateComprobante_Pago(string cod_sunat, string des_comp,
            string des_comp_breve, string idusu, string fecha, string idcomPago)
        {
            cdcompro.EditarComprobante_Pago(cod_sunat, des_comp, des_comp_breve, Convert.ToInt32(idusu), 
                fecha, Convert.ToInt32(idcomPago));
        }

        //DELETE COMPROBANTE_PAGO
        public void DeleteComprobante_Pago(string idcomPago)
        {
            cdcompro.EliminarComprobante_Pago(Convert.ToInt32(idcomPago));
        }
    }
}
