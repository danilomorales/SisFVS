using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
   public class CNClientes
    {
        private CDCliente cli = new CDCliente();

        //READ CLIENT
        public DataTable MostarClientes()
        {
            DataTable table = new DataTable();
            table = cli.listarClientes();
            return table;
        }

        //CREATE CLIENT
        public void InsertClient(String idtienda, String idsector, String nombre_Empresa, String direccion, String contacto, String telefono, String fax, String ruc, String email,
            String idtipo_doc, String nroDocumento, String observacion, String inscripcion, String estado, String saldocta, String nivel, String fechaNac, String tipoCompra,
            String credito, String queja, String saldo_Inicial, String ordenCliente, String tipoCliente, String promedio_ventas, String cta_cli)
        {
            Console.WriteLine("Sera pues ..." + idtienda + " " + idsector + " " + nombre_Empresa + " " + direccion + " " + contacto + " " + telefono + " " +
            fax + " " + ruc + " " + email + " " + idtipo_doc + " " + nroDocumento + " " + observacion + " " + inscripcion + " " + estado + " " +
            saldocta + " " + nivel + " " + fechaNac + " " + tipoCompra + " " + credito + "   " + queja + " " + saldo_Inicial + "   " + ordenCliente + "   "
            +tipoCliente + "   " + promedio_ventas + "   " + cta_cli );
            cli.InsertarCliente(idtienda, idsector,nombre_Empresa,direccion,contacto,telefono,fax,ruc,email,idtipo_doc,nroDocumento,observacion,
                Convert.ToDateTime(inscripcion),estado,Convert.ToDouble(saldocta),nivel,
                Convert.ToDateTime(fechaNac),tipoCompra,Convert.ToDouble(credito),queja,saldo_Inicial,
                Convert.ToInt32(ordenCliente),tipoCliente,Convert.ToDouble(promedio_ventas),cta_cli);
        }

        //UPDATE CLIENT
        public void UpdateClient(String idCliente, String idtienda, String idsector, String nombre_Empresa, String direccion, String contacto, String telefono, String fax, String ruc,
            String email,String idtipo_doc, String nroDocumento, String observacion, String inscripcion, String estado, String saldocta, String nivel, String fechaNac,
            String tipoCompra,String credito, String queja, String saldo_Inicial, String ordenCliente, String tipoCliente, String promedio_ventas, String cta_cli)
        {
            cli.EditarProducto(idCliente,idtienda, idsector, nombre_Empresa, direccion, contacto, telefono, fax, ruc, email, idtipo_doc, nroDocumento, observacion,
                Convert.ToDateTime(inscripcion), estado, Convert.ToDouble(saldocta), nivel,
                Convert.ToDateTime(fechaNac), tipoCompra, Convert.ToDouble(credito), queja, saldo_Inicial,
                Convert.ToInt32(ordenCliente), tipoCliente, Convert.ToDouble(promedio_ventas), cta_cli);
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
    }
}
