using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
   public class CNClientes
    {
         CDCliente cli = new CDCliente();

        //READ CLIENT
        public SqlDataAdapter MostarClientes()
        {
            return  cli.listarClientes();
       
        }

        //CREATE CLIENT
        public void InsertClient(String idDocIdentidad, String idTipoPersona, String nDocIdentidad, String numeroRuc, String razonSocial, String nombreComercial,
            String nombre, String paterno, String materno, String correo, String direccion, String fax, String fijo, String telefono, String fechaNacimiento, 
            String depa, String provi, String distri, String usuarioRegistra, String fechaRegistro, String usuarioModifica, String fechaModifica, 
            String idSector, String observacion)
        {
            Console.WriteLine("Sera pues ..." + idDocIdentidad + " " + idTipoPersona + " " + nDocIdentidad + " " + direccion + " " + numeroRuc + " " + razonSocial + " " +
            nombreComercial + " " + nombre + " " + paterno + " " + materno + " " + correo + " " + observacion + " " + direccion + " " + fax + " " +
            fijo + " " + telefono + " " + fechaNacimiento + " " + depa + " " + provi + "   " + distri + " "  + usuarioRegistra + "   "
            + fechaRegistro + "   " + usuarioModifica + "   " + fechaModifica + "   " + idSector + "   " + observacion);
            cli.InsertarCliente(Convert.ToInt32(idDocIdentidad),Convert.ToInt32(idTipoPersona),nDocIdentidad,numeroRuc,razonSocial,nombreComercial,
                nombre,paterno,materno,correo,direccion,fax,fijo,telefono,fechaNacimiento,depa,provi,distri,Convert.ToInt32(usuarioRegistra),fechaRegistro,
                Convert.ToInt32(usuarioModifica),fechaModifica,idSector,observacion);
        }

        //UPDATE CLIENT
        public void UpdateClient(String idRecpCliente, String idDocIdentidad, String idTipoPersona, String nDocIdentidad, String numeroRuc, String razonSocial,String nombreComercial,
            String nombre, String paterno, String materno, String correo, String direccion, String fax, String fijo, String telefono, String fechaNacimiento,
            String depa, String provi, String distri, String usuarioRegistra, String fechaRegistro, String usuarioModifica, String fechaModifica,
            String idSector, String observacion)
        {
            Console.WriteLine("EDITACIONNNNNN ..." + idDocIdentidad + " " + idTipoPersona + " " + nDocIdentidad + " " + numeroRuc + " " + razonSocial + " " +
            nombreComercial + " " + nombre + " " + paterno + " " + materno + " " + correo + " " + direccion + " " + fax + " " +
            fijo + " " + telefono + " " + fechaNacimiento + " " + depa + " " + provi + "   " + distri + " " + usuarioRegistra + "   "
            + fechaRegistro + "   " + usuarioModifica + "   " + fechaModifica + "   " + idSector + "   " + observacion+"  "+ idRecpCliente);

            cli.EditarCliente(Convert.ToInt32(idRecpCliente), Convert.ToInt32(idDocIdentidad), Convert.ToInt32(idTipoPersona), nDocIdentidad, numeroRuc, razonSocial, nombreComercial,
                nombre, paterno, materno, correo, direccion, fax, fijo, telefono, fechaNacimiento, depa, provi, distri, Convert.ToInt32(usuarioRegistra), fechaRegistro,
                Convert.ToInt32(usuarioModifica), fechaModifica, idSector, observacion);
        }

        //DELETE CLIENT
        public void DeleteClient(String idRecpCliente)
        {
            cli.EliminarCliente(idRecpCliente);
        }

        //busca Cliente
        public static DataTable BuscarApellidos(string textobuscar)
        {
            CDCliente Obj = new CDCliente();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarApellidos(Obj);
        }
        //busca cod
        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            CDCliente Obj = new CDCliente();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }

        //Carga Cliente Filtro Venta

        public SqlDataAdapter CargaProductoFiltro()
        {
            SqlDataAdapter cliente;
            cliente = cli.CargaClienteRedeptor();
            return cliente;
        }
    }
}
