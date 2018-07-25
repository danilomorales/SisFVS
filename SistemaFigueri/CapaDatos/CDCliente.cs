using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDCliente
    {
        private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        //Listar Clientes
        public DataTable listarClientes()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select c.IdCliente,t.NombreTienda as 'Nombre de la Tienda',s.DescripcionSector as 'Nombre del sector'," +
                "c.NombreEmpresa as 'Nombre de la Empresa', c.Direccion,c.Contacto as 'Nombre del Contacto',c.Telefono,c.Fax,c.RUC,c.Email as 'Correo'," +
                "c.IdTipoDocIdent 'Documento', c.NroDocumento as 'Nr° del Documento',c.Observacion as 'Observación',c.Inscripcion as 'Inscripción',c.Estado," +
                "c.SaldoCtaCte as 'Cuenta Corriente',c.Nivel, c.FechaNac as 'Fecha de Nacimiento',c.TipoCompra as 'Tipo de Compra',c.Credito,c.Queja," +
                "c.EstSaldoIni as 'Estado Inicial', c.OrdenCliente as 'Orden del Cliente',c.TipoCliente as 'Tipo de Cliente',c.PromedioDeVentas as 'Promedio de ventas'," +
                " c.cta_cli from caja.CLIENTE c, dbo.TIENDA t, dbo.SECTOR s where c.IdTienda = t.IdTienda AND c.IdSector = s.IdSector";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
