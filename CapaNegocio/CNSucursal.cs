using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CNSucursal
    {
        CDSucursal sucu = new CDSucursal();
        //READALL SUCURSAL
        public SqlDataAdapter MostarSucursal()
        {
            return sucu.listarSucursal();
        }

        //INSERT SUCURSAL
        public void InsertSucursal(string nombe_sucu, string fecha_registro){
            sucu.InsertarSucursal(nombe_sucu, fecha_registro);
        }

        //UPDATE SUCURSAL
        public void UpdateSucursal(string nombe_sucu, string fecha_registro,string idSucu)
        {
            sucu.EditarSucursal(nombe_sucu, fecha_registro,Convert.ToInt32(idSucu));
        }

        //DELETE SUCURSAL
        public void DeleteSucursal(string idSucu)
        {
            sucu.EliminarSucursal(Convert.ToInt32(idSucu));
        }

        //READALL TIENDA
        public SqlDataAdapter MostarTienda()
        {
            return sucu.listarTienda();
        }

        //INSERT TIENDA
        public void InsertTienda(string idResponsable, string nombreTienda, string direccion, string telefono, string serie, string ideSucursal)
        {
            sucu.InsertarTienda(idResponsable, nombreTienda,direccion,telefono,Convert.ToInt32(serie),Convert.ToInt32(ideSucursal));
        }

        //UPDATE TIENDA
        public void UpdateTienda(string idResponsable, string nombreTienda, string direccion, string telefono, string serie, string ideSucursal, string idTienda)
        {
            sucu.EditarTienda(idResponsable, nombreTienda, direccion, telefono, Convert.ToInt32(serie), Convert.ToInt32(ideSucursal), idTienda);
        }

        //DELETE TIENDA
        public void DeleteTienda(string idTienda)
        {
            sucu.EliminarTienda(idTienda);
        }

        //READALL SECTOR
        public SqlDataAdapter MostarSector()
        {
            return sucu.listarSector();
        }

        //INSERT SECTOR
        public void InsertSector(string descripcion, string nota, string idTienda, string porcentaje)
        {
            Console.Write("Se inserto SECTOR:" + descripcion + " " + nota + "  " + idTienda + "  " + porcentaje);
            sucu.InsertarSector(descripcion, nota, idTienda, Convert.ToDouble(porcentaje));
        }

        //UPDATE SECTOR
        public void UpdateSector(string descripcion, string nota, string idTienda, string porcentaje,string idSector)
        {
            sucu.EditarSector(descripcion, nota, idTienda, Convert.ToDouble(porcentaje), idSector);
        }

        //DELETE SECTOR
        public void DeleteSector(string idSector)
        {
            sucu.EliminarSector(idSector);
        }

        //READALL PUNTO_VENTA
        public SqlDataAdapter MostarPunto_Venta()
        {
            return sucu.listarPunto_Venta();
        }

        //INSERT PUNTO_VENTA
        public void InsertPunto_Venta(string des_puntoVenta, string ide, string idSector, string flg_puntoVenta, string idUsu, string fecha)
        {
            sucu.InsertarPunto_Venta(des_puntoVenta, Convert.ToInt32(ide), idSector, Convert.ToInt32(flg_puntoVenta),Convert.ToInt32(idUsu),fecha);
        }

        //UPDATE PUNTO_VENTA
        public void UpdatePunto_Venta(string des_puntoVenta, string ide, string idSector, string flg_puntoVenta, string idUsu, string fecha,string idpunto_venta)
        {
            sucu.EditarPunto_Venta(des_puntoVenta, Convert.ToInt32(ide), idSector, Convert.ToInt32(flg_puntoVenta), Convert.ToInt32(idUsu), fecha,Convert.ToInt32(idpunto_venta));
        }

        //DELETE PUNTO_VENTA
        public void DeletePunto_Venta(string idpunto_venta)
        {
            sucu.EliminarPunto_Venta(Convert.ToInt32(idpunto_venta));
        }
    }
}
