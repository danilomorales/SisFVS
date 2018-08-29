using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using CapaEntidades;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class CNClientes
    {
        private static readonly CNClientes _intancia = new CNClientes();
        public static CNClientes Intancia
        {
            get { return CNClientes._intancia; }
        }

        CDCliente cli = new CDCliente();

        //READ CLIENT
        public SqlDataAdapter MostarClientes()
        {
            return cli.listarClientes();

        }

        //CREATE CLIENT
        public void InsertClient(String idTienda, String idSector, String nombreEmpresa, String nombres, String apellidoP, String apellidoM,
            String direccion, String contacto, String telefono, String fax, String ruc, String correo, String idTipoDoc, String nroDoc, String observacion,
            String inscripcion, String salCta, String fechaNac, String tipoCompra, String credito, String queja, String ordenclie, String promedioVentas,
            String cta_cli, String depa, String provi, String distri, String usuRegistra)
        {
            Console.WriteLine("Sera pues ..." + idTienda + " " + idSector + " " + nombreEmpresa + " " + nombres + " " + apellidoP + " " + apellidoM + " " +
            direccion + " " + contacto + " " + telefono + " " + fax + " " + ruc + " " + correo + " " + idTipoDoc + " " + nroDoc + " " +
            observacion + " " + inscripcion + " " + salCta + " " + fechaNac + " " + tipoCompra + "   " + credito + " " + queja + "   "
            + ordenclie + "   " + promedioVentas + "   " + cta_cli + "   " + depa + "   " + provi + "   " + distri + "   " + usuRegistra);
            cli.InsertarCliente(idTienda, idSector, nombreEmpresa, nombres, apellidoP, apellidoM, direccion, contacto, telefono, fax, ruc, correo, idTipoDoc, nroDoc,
                observacion, inscripcion, Convert.ToDouble(salCta), fechaNac, tipoCompra, Convert.ToDouble(credito), queja, Convert.ToInt32(ordenclie),
                Convert.ToDouble(promedioVentas), cta_cli, depa, provi, distri, usuRegistra);
        }

        //UPDATE CLIENT
        public void UpdateClient(String idCliente, String idTienda, String idSector, String nombreEmpresa, String nombres, String apellidoP, String apellidoM,
            String direccion, String contacto, String telefono, String fax, String ruc, String correo, String idTipoDoc, String nroDoc, String observacion,
            String inscripcion, String salCta, String fechaNac, String tipoCompra, String credito, String queja, String ordenclie, String promedioVentas,
            String cta_cli, String depa, String provi, String distri, String usuRegistra, String usuModifica, String fechaModi)
        {
            Console.WriteLine("Editadooooo ..." + idCliente + "" + idTienda + " " + idSector + " " + nombreEmpresa + " " + nombres + " " + apellidoP + " " + apellidoM + " " +
             direccion + " " + contacto + " " + telefono + " " + fax + " " + ruc + " " + correo + " " + idTipoDoc + " " + nroDoc + " " +
             observacion + " " + inscripcion + " " + salCta + " " + fechaNac + " " + tipoCompra + "   " + credito + " " + queja + "   "
             + ordenclie + "   " + promedioVentas + "   " + cta_cli + "   " + depa + "   " + provi + "   " + distri + "   " + usuRegistra);

            cli.EditarCliente(idCliente, idTienda, idSector, nombreEmpresa, nombres, apellidoP, apellidoM, direccion, contacto, telefono, fax, ruc, correo, idTipoDoc, nroDoc, observacion, inscripcion,
                Convert.ToDouble(salCta), fechaNac, tipoCompra, Convert.ToDouble(credito), queja, Convert.ToInt32(ordenclie), Convert.ToDouble(promedioVentas), cta_cli, depa, provi, distri, usuRegistra,
                usuModifica, fechaModi);
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

        //public SqlDataAdapter CargaProductoFiltro()
        //{
        //    SqlDataAdapter cliente;
        //    cliente = cli.CargaClienteRedeptor();
        //    return cliente;
        //}
        //ListaPRoductos paraventa
        public List<CECliente> ListaClienteVenta()
        {
            try
            {
                List<CECliente> Lista = CDCliente.Intancia.ListaCLienteVenta();
                if (Lista.Count <= 0) throw new ApplicationException("Lista de clientes vacia");
                else if (Lista == null) throw new ApplicationException("Error al cargar lista de clientes");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Buscar Cliente En textbox
        public CECliente BuscarCliente(int id_cli, String nro_Doc)
        {
            try
            {
                CECliente c = null;
                c = CDCliente.Intancia.BuscarCliente(id_cli, nro_Doc);
                if (c == null) throw new ApplicationException("No se encontro registro");
                return c;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //BUsca Cliente Según TextBox
        public List<CECliente> BuscarClienAvanzada(int tip_busq, String val_busqueda)
        {
            try
            {
                List<CECliente> Lista = null;
                Lista = CDCliente.Intancia.BuscarClienteAvanzada(tip_busq, val_busqueda);
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}