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

        //LISTAR CLIENTE
        public DataTable listarClientes()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select c.IdClienteReceptor,c.Nombres,c.ApellidoPaterno as 'Apellido Paterno',c.ApellidoMaterno as 'Apellido Materno',p.Descripcion as 'Tipo de Persona',t.Nombre as 'Tipo de Documento'," +
                "c.NroDocIdentidad as 'Nro de Documento',c.NumeroRuc as 'Nro de RUC',c.RazonSocial as 'Razón Social',c.NombreComercial as 'Nombre Comercial',c.Correo,c.Direccion as 'Dirección',c.Fax,c.Fijo,c.Telefono," +
                "c.FechaNacimiento as 'Fecha de Nacimiento',c.Departamento,c.Provincia,c.Distrito,c.Estado,c.UsuarioRegistra as 'Usuario Registra',c.FechaRegistro as 'Fecha de Registro',c.UsuarioModifica as 'Usuario Modifica'," +
                "c.FechaModifica as 'Fecha Modifica',s.DescripcionSector as 'Sector',c.Observacion as 'Observación'" +
                "from caja.ClienteReceptor c,caja.TipoPersona p, caja.SECTOR s, caja.DocIdentidad t where c.IdTipoPersona = p.IdTipoPersona and c.IdSector = s.IdSector and c.IdDocIdentidad = t.IdDocIdentidad";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;




        }

        //INSERTAR CLIENTE
        public void InsertarCliente(String idtienda,String idsector,String nombre_Empresa,String direccion,String contacto,String telefono,String fax,String ruc,String email,
            String idtipo_doc,String nroDocumento,String observacion,DateTime inscripcion,String estado,double saldocta,String nivel,DateTime fechaNac,String tipoCompra,
            double credito, String queja,String saldo_Inicial,int ordenCliente,String tipoCliente,double promedio_ventas,String cta_cli)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into caja.CLIENTE(IdTienda,IdSector,NombreEmpresa,Direccion,Contacto,Telefono,Fax,RUC,Email,IdTipoDocIdent,NroDocumento,Observacion,Inscripcion,Estado,SaldoCtaCte,Nivel,FechaNac,TipoCompra,Credito,Queja,EstSaldoIni,OrdenCliente,TipoCliente,PromedioDeVentas,cta_cli)" +
                "values('" + idtienda + "', '" + idsector + "', '" + nombre_Empresa + "', '" + direccion + "', '" + contacto + "', '" + telefono + "', '" + fax + "', '" + ruc + "', '" + email + "', '" + idtipo_doc + "','" + nroDocumento + "', '" + observacion + "'," +
                " '" + inscripcion + "', '" + estado + "','" + saldocta + "', '" + nivel + "','" + fechaNac + "', '" + tipoCompra + "', '" + credito + "', '" + queja + "', '" + saldo_Inicial + "', '" + ordenCliente + "','" + tipoCliente + "', '" + promedio_ventas + "','" + cta_cli + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        //EDITAR CLIENTE
        public void EditarProducto(String idCliente,String idtienda, String idsector, String nombre_Empresa, String direccion, String contacto, String telefono, String fax, String ruc, String email,
            String idtipo_doc, String nroDocumento, String observacion, DateTime inscripcion, String estado, double saldocta, String nivel, DateTime fechaNac, String tipoCompra,
            double credito, String queja, String saldo_Inicial, int ordenCliente, String tipoCliente, double promedio_ventas, String cta_cli)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = " update caja.CLIENTE set IdTienda='" + idtienda + "',IdSector='" + idsector + "',NombreEmpresa='" + nombre_Empresa + "'," +
                "Direccion='" + direccion + "',Contacto='" + contacto + "',Telefono='" + telefono + "',Fax='" + fax + "',RUC='" + ruc + "'," +
                "Email = '" + email + "',IdTipoDocIdent = '" + idtipo_doc + "',NroDocumento = '" + nroDocumento + "',Observacion = '" + observacion + "'," +
                "Inscripcion ='" + inscripcion + "',Estado ='" + estado + "',SaldoCtaCte ='" + saldocta + "',Nivel ='" + nivel + "',FechaNac ='" + fechaNac + "'," +
                "TipoCompra = '" + tipoCompra + "',Credito = '" + credito + "',Queja ='" + queja + "',EstSaldoIni ='" + saldo_Inicial + "',OrdenCliente ='" + ordenCliente + "'," +
                "TipoCliente ='" + tipoCliente + "',PromedioDeVentas ='" + promedio_ventas + "',cta_cli ='" + cta_cli + "' where IdCliente ='" + idCliente + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        //ELIMINAR CLIENTE
        public void EliminarCliente(String idCliente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = " delete from Caja.CLIENTE where IdCliente='" + idCliente + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        //Llenar comboBox Documento
        public DataTable ListarDocumento()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from caja.DocIdentidad";
            leer = comando.ExecuteReader();
            table.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return table;
        }

        //Llenar comboBox TIPOPERSONA
        public DataTable ListarPersona()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from caja.TipoPersona";
            leer = comando.ExecuteReader();
            table.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return table;
        }

        //Llenar comboBox SECTOR
        public DataTable ListarSector()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from caja.SECTOR";
            leer = comando.ExecuteReader();
            table.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return table;
        }

        ////Llenar ComboBox DEPARTAMENTO
        //public DataTable ListarDepartamento()
        //{
        //    DataTable table = new DataTable();
        //    comando.Connection = conexion.AbrirConexion();
        //    comando.CommandText = "select Departamento from caja.Ubigeo order by Departamento";
        //    leer = comando.ExecuteReader();
        //    table.Load(leer);
        //    leer.Close();
        //    conexion.CerrarConexion();
        //    return table;
        //}
    }
}
