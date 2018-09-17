using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CE_FE_Comprobante_VentaPago
    {
        Int64 ide_venta;

        public Int64 Ide_Venta
        {
            get { return ide_venta; }
            set { ide_venta = value; }
        }

        int num_item_venta_pago;

        public int Num_Item_Venta_Pago
        {
            get { return num_item_venta_pago; }
            set { num_item_venta_pago = value; }
        }

        int ide_forma_pago;

        public int Ide_Forma_Pago
        {
            get { return ide_forma_pago; }
            set { ide_forma_pago = value; }
        }

        int ide_tarjeta_banco;

        public int Ide_Tarjeta_Banco
        {
            get { return ide_tarjeta_banco; }
            set { ide_tarjeta_banco = value; }
        }

        int ide_banco;

        public int Ide_Banco
        {
            get { return ide_banco; }
            set { ide_banco = value; }
        }

        int ide_banco_cuenta;

        public int Ide_Banco_Cuenta
        {
            get { return ide_banco_cuenta; }
            set { ide_banco_cuenta = value; }
        }

        DateTime fecha_doc_pago;

        public DateTime Fecha_Doc_Pago
        {
            get { return fecha_doc_pago; }
            set { fecha_doc_pago = value; }
        }

        string num_doc_pago;

        public string Num_Doc_Pago
        {
            get { return num_doc_pago; }
            set { num_doc_pago = value; }
        }

        int ide_moneda;

        public int Ide_Moneda
        {
            get { return ide_moneda; }
            set { ide_moneda = value; }
        }

        Double imp_pago;

        public Double Imp_Pago
        {
            get { return imp_pago; }
            set { imp_pago = value; }
        }

        int ide_usuario;

        public int Ide_Usuario
        {
            get { return ide_usuario; }
            set { ide_usuario = value; }
        }
    }
}
