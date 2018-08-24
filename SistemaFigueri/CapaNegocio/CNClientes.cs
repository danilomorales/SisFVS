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
        public void InsertClient(String idTienda, String idSector, String nombreEmpresa, String nombres, String apellidoP, String apellidoM,
            String direccion, String contacto, String telefono, String fax, String ruc, String correo, String idTipoDoc, String nroDoc, String observacion,
            String inscripcion, String salCta, String fechaNac, String tipoCompra, String credito, String queja, String ordenclie, String promedioVentas,
            String cta_cli, String depa, String provi, String distri, String usuRegistra)
        {
            Console.WriteLine("Sera pues ..." + idTienda + " " + idSector + " " + nombreEmpresa + " " + nombres + " " + apellidoP + " " + apellidoM + " " +
            direccion + " " + contacto + " " + telefono + " " + fax + " " + ruc + " " + correo + " " + idTipoDoc + " " + nroDoc + " " +
            observacion + " " + inscripcion + " " + salCta + " " + fechaNac + " " + tipoCompra + "   " + credito + " "  + queja + "   "
            + ordenclie + "   " + promedioVentas + "   " + cta_cli + "   " + depa + "   " + provi + "   " + distri + "   " + usuRegistra);
            cli.InsertarCliente(idTienda,idSector,nombreEmpresa,nombres,apellidoP,apellidoM,direccion,contacto,telefono,fax,ruc,correo,idTipoDoc,nroDoc,
                observacion,inscripcion,Convert.ToDouble(salCta),fechaNac,tipoCompra,Convert.ToDouble(credito),queja,Convert.ToInt32(ordenclie),
                Convert.ToDouble(promedioVentas),cta_cli,depa,provi,distri,usuRegistra);
        }

        //UPDATE CLIENT
        public void UpdateCliente(String idCliente, String idTienda, String idSector, String nombreEmpresa, String nombres, String apellidoP, String apellidoM,
            String direccion, String contacto, String telefono, String fax, String ruc, String correo, String idTipoDoc, String nroDoc, String observacion,
            String inscripcion, String salCta, String fechaNac, String tipoCompra, String credito, String queja, String ordenclie, String promedioVentas,
            String cta_cli, String depa, String provi, String distri, String usuRegistra, String usuModifica, String fechaModi)
        {
            Console.WriteLine("Editadooooo ..."+ idCliente + "" + idTienda + " " + idSector + " " + nombreEmpresa + " " + nombres + " " + apellidoP + " " + apellidoM + " " +
             direccion + " " + contacto + " " + telefono + " " + fax + " " + ruc + " " + correo + " " + idTipoDoc + " " + nroDoc + " " +
             observacion + " " + inscripcion + " " + salCta + " " + fechaNac + " " + tipoCompra + "   " + credito + " " + queja + "   "
             + ordenclie + "   " + promedioVentas + "   " + cta_cli + "   " + depa + "   " + provi + "   " + distri + "   " + usuRegistra);

            cli.EditarCliente(idCliente,idTienda,idSector,nombreEmpresa,nombres,apellidoP,apellidoM,direccion,contacto,telefono,fax,ruc,correo,idTipoDoc,nroDoc,observacion,inscripcion,
                Convert.ToDouble(salCta),fechaNac,tipoCompra,Convert.ToDouble(credito),queja,Convert.ToInt32(ordenclie),Convert.ToDouble(promedioVentas),cta_cli,depa,provi,distri,usuRegistra,
                usuModifica,fechaModi);
        }


        //DELETE CLIENT
        public void DeleteClient(String idCliente)  
        {
            cli.EliminarCliente(idCliente);
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
