using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CE_FE_Comprobante_VentaEstado
    {
        int ide_Venta;

        public int Ide_Venta { get => ide_Venta; set => ide_Venta = value; }

        private int num_item_comp_venta_estado;

        public int Num_Item_Comp_Venta_Estado
        {
            get { return num_item_comp_venta_estado; }
            set { num_item_comp_venta_estado = value; }
        }

        int ide_estado_venta;

        public int Ide_estado_venta { get => ide_estado_venta; set => ide_estado_venta = value; }

        string obs_comp_vta_estado;

        public string Obs_comp_vta_estado
        {
            get { return obs_comp_vta_estado; }
            set { obs_comp_vta_estado = value; }
        }

        int ide_usuario;

        public int Ide_Usuario
        {
            get { return ide_usuario; }
            set { ide_usuario = value; }
        }



    }
}
