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

       CECliente cliente = new CECliente();

        //READ CLIENT
        public SqlDataAdapter MostarClientes()
        {
            return cli.listarClientes();

        }

        //CREATE CLIENT
        public void InsertClient(string idTienda, string idSector, string nombre, string apellidoP, string apellidoM, string nombreEmpre,
            string direccion, string contacto, string telefono, string fax, string ruc, string email, string idtipoPersona, string idtipoDocIdent,
            string nroDocumento, string observacion, string inscripcion, string fechaNac, string credito, string tipoCliente, string depa,
            string provi, string distri, string usuRegistra)
        {
            Console.WriteLine("Insertando Cliente: ..." + idTienda + " " + idSector + " " + nombre + " " + apellidoP + " " + apellidoM + " " + nombreEmpre+" "+
            direccion + " " + contacto + " " + telefono + " " + fax + " " + ruc + " " + email + " " + idtipoPersona + " " + idtipoDocIdent + " " +
            nroDocumento + " " + observacion + " " + inscripcion + " " + fechaNac + " " + credito + "   " + tipoCliente + 
             "   " + depa + "   " + provi + "   " + distri + "   " + usuRegistra);
            cli.InsertarCliente(idTienda,idSector,nombre,apellidoP,apellidoM,nombreEmpre,direccion,contacto,telefono,fax,ruc,email,
                Convert.ToInt32(idtipoPersona),idtipoDocIdent,nroDocumento,observacion,inscripcion,fechaNac,Convert.ToDouble(credito),tipoCliente,
                depa,provi,distri,usuRegistra);
        }

        //UPDATE CLIENT
        public void UpdateClient(string idTienda, string idSector, string nombre, string apellidoP, string apellidoM, string nombreEmpre,
            string direccion, string contacto, string telefono, string fax, string ruc, string email, string idtipoPersona, string idtipoDocIdent,
            string nroDocumento, string observacion, string inscripcion, string fechaNac, string credito, string tipoCliente, string depa,
            string provi, string distri, string usuRegistra, string usuModifica, string fechaModifica, string idCliente)
        {
            try
            {
                Console.WriteLine("EDITANDOOOO Cliente: ..." + idTienda + " " + idSector + " " + nombre + " " + apellidoP + " " + apellidoM + " " + nombreEmpre + " " +
            direccion + " " + contacto + " " + telefono + " " + fax + " " + ruc + " " + email + " " + idtipoPersona + " " + idtipoDocIdent + " " +
            nroDocumento + " " + observacion + " " + inscripcion + " " + fechaNac + " " + credito + "   " + tipoCliente +
             "   " + depa + "   " + provi + "   " + distri + "   " + usuRegistra + "   " + usuModifica + "   " + fechaModifica + "   " + idCliente);
                cli.EditarCliente(idTienda, idSector, nombre, apellidoP, apellidoM, nombreEmpre, direccion, contacto, telefono, fax, ruc, email,
                    Convert.ToInt32(idtipoPersona), idtipoDocIdent, nroDocumento, observacion, inscripcion, fechaNac, Convert.ToDouble(credito), tipoCliente,
                    depa, provi, distri, usuRegistra, usuModifica, fechaModifica, idCliente);
            }
            catch (Exception ex)
            {
                Console.WriteLine("VIENE DEL CN" + ex);
            }
           
        }


        //DELETE CLIENT
        public void DeleteClient(string idcliente)
        {
            cli.EliminarCliente(idcliente);
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

        public List<String> filtroClienteEmpresa()
        {
            List<String> Lista = cli.filtroClienteEmpresa();
            if (Lista.Count <= 0) throw new ApplicationException("Lista de clientes vacia");
            else if (Lista == null) throw new ApplicationException("Error al cargar lista de clientes");
            return Lista;
            
        }

        //Buscar empresa
        public CECliente BuscarClienteEmpresa(int id_cli, String empresa)
        {
            try
            {
                CECliente c = null;
                c = CDCliente.Intancia.BuscarClienteEmpresa(id_cli, empresa);
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
        //Cargqa Cliente para bsusqueda 

        public SqlDataAdapter CargaCliente()
        {
            SqlDataAdapter cliente;
            cliente = cli.CargaClienteBusqueda();
            return cliente;
        }


        public CE_Cliente LlenaEntidad_Cliente(string IdCliente)
        {
            CE_Cliente dObj_Cliente = new CE_Cliente();
            DataTable dTbl_Cliente;

            dTbl_Cliente = cli.LlenaEntidad_Cliente(IdCliente);
            //dObj_Cliente.IdCliente = int.Parse(dTbl_Cliente.Rows[0]["IdCliente"].ToString());
            dObj_Cliente.IdCliente = dTbl_Cliente.Rows[0]["IdCliente"].ToString();
            dObj_Cliente.IdTipoDocIdent = dTbl_Cliente.Rows[0]["IdTipoDocIdent"].ToString();
            dObj_Cliente.IdSector = dTbl_Cliente.Rows[0]["IdSector"].ToString();
            dObj_Cliente.IdTipoPersona = int.Parse(dTbl_Cliente.Rows[0]["IdTipoPersona"].ToString());
            dObj_Cliente.Nombres = dTbl_Cliente.Rows[0]["Nombres"].ToString();
            dObj_Cliente.ApellidoPaterno = dTbl_Cliente.Rows[0]["ApellidoPaterno"].ToString();
            dObj_Cliente.ApellidoMaterno = dTbl_Cliente.Rows[0]["ApellidoMaterno"].ToString();
            dObj_Cliente.NombreEmpresa = dTbl_Cliente.Rows[0]["NombreEmpresa"].ToString();
            dObj_Cliente.Direccion = dTbl_Cliente.Rows[0]["Direccion"].ToString();
            dObj_Cliente.Direccion = dTbl_Cliente.Rows[0]["Direccion"].ToString();
            dObj_Cliente.Contacto = dTbl_Cliente.Rows[0]["Contacto"].ToString();
            dObj_Cliente.Fax = dTbl_Cliente.Rows[0]["Fax"].ToString();
            dObj_Cliente.RUC = dTbl_Cliente.Rows[0]["RUC"].ToString();
            dObj_Cliente.NroDocumento = dTbl_Cliente.Rows[0]["NroDocumento"].ToString();
            dObj_Cliente.IdUbigeo = dTbl_Cliente.Rows[0]["IdUbigeo"].ToString();
            dObj_Cliente.Departamento = dTbl_Cliente.Rows[0]["IdUbigeo"].ToString();
            dObj_Cliente.Provincia = dTbl_Cliente.Rows[0]["Departamento"].ToString();
            dObj_Cliente.Distrito = dTbl_Cliente.Rows[0]["Distrito"].ToString();
            dObj_Cliente.Estado = char.Parse(dTbl_Cliente.Rows[0]["Estado"].ToString());

            return dObj_Cliente;
        }
    }
}