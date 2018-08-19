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
        private SqlDataAdapter adapter;


        //var
        private string _Textobuscar;

        public string Textobuscar { get => _Textobuscar; set => _Textobuscar = value; }
        public CDCliente()
        {

        }
        public CDCliente(string textobuscar)
        {
            this.Textobuscar = textobuscar;
        }

        public DataTable BuscarApellidos(CDCliente cliente)
        {
            DataTable dtResultado = new DataTable("cliente");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = conexion.AbrirConexion();
                sqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;
                SqlCmd.CommandText = "SP_BuscaClienteApellidos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@txtBusca";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = cliente.Textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtResultado);


            }
            catch (Exception ex)

            {
                dtResultado = null;

            }
            return dtResultado;
        }

        public DataTable BuscarNum_Documento(CDCliente Cliente)
        {
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = conexion.AbrirConexion();
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscaClienteDocumento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@txtBusca";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.Textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        //LISTAR CLIENTE
        public SqlDataAdapter listarClientes()
        {
            String sql = "select c.IdClienteReceptor,c.Nombres,c.ApellidoPaterno as 'Apellido Paterno',c.ApellidoMaterno as 'Apellido Materno',p.Descripcion as 'Tipo de Persona',t.Nombre as 'Tipo de Documento'," +
                "c.NroDocIdentidad as 'Nro de Documento',c.NumeroRuc as 'Nro de RUC',c.RazonSocial as 'Razón Social',c.NombreComercial as 'Nombre Comercial',c.Correo,c.Direccion as 'Dirección',c.Fax,c.Fijo,c.Telefono," +
                "c.FechaNacimiento as 'Fecha de Nacimiento',c.Departamento,c.Provincia,c.Distrito,c.Estado,c.UsuarioRegistra as 'Usuario Registra',c.FechaRegistro as 'Fecha de Registro',c.UsuarioModifica as 'Usuario Modifica'," +
                "c.FechaModifica as 'Fecha Modifica',s.DescripcionSector as 'Sector',c.Observacion as 'Observación'" +
                "from caja.ClienteReceptor c,caja.TipoPersona p, caja.SECTOR s, caja.DocIdentidad t where c.IdTipoPersona = p.IdTipoPersona and c.IdSector = s.IdSector and c.IdDocIdentidad = t.IdDocIdentidad";
            adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
            return adapter;
        }

        //INSERTAR CLIENTE
        public void InsertarCliente(int idDocIdentidad, int idTipoPersona, String nDocIdentidad,String numeroRuc,String razonSocial,String nombreComercial,
            String nombre,String paterno,String materno,String correo,String direccion,String fax,String fijo,String telefono, String fechaNacimiento,
            String depa,String provi,String distri,int usuarioRegistra, String fechaRegistro,int usuarioModifica, String fechaModifica,String idSector,String observacion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into caja.ClienteReceptor(IdDocIdentidad,IdTipoPersona,NroDocIdentidad,NumeroRuc,RazonSocial,NombreComercial,Nombres,ApellidoPaterno,ApellidoMaterno,Correo,Direccion,Fax,Fijo,Telefono,FechaNacimiento,Departamento,Provincia,Distrito,Estado,UsuarioRegistra,FechaRegistro,UsuarioModifica,FechaModifica,IdSector,Observacion) " +
                "values('" + idDocIdentidad + "', '" + idTipoPersona + "', '" + nDocIdentidad + "', '" + numeroRuc + "', '" + razonSocial + "', '" + nombreComercial + "', '" + nombre + "', '" + paterno + "', '" + materno + "', '" + correo + "','" + direccion + "', '" + fax + "'," +
                " '" + fijo + "', '" + telefono + "','" + fechaNacimiento + "', '" + depa + "','" + provi + "', '" + distri + "', '1', '" + usuarioRegistra + "', '" + fechaRegistro + "', '" + usuarioModifica + "','" + fechaModifica + "', '" + idSector + "','" + observacion + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
        
        //EDITAR CLIENTE
        public void EditarCliente(int idRecpCliente, int idDocIdentidad, int idTipoPersona, String nDocIdentidad, String numeroRuc, String razonSocial, String nombreComercial,
            String nombre, String paterno, String materno, String correo, String direccion, String fax, String fijo, String telefono, String fechaNacimiento,
            String depa, String provi, String distri, int usuarioRegistra, String fechaRegistro, int usuarioModifica, String fechaModifica, String idSector, String observacion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = " update Caja.ClienteReceptor set IdDocIdentidad=" + idDocIdentidad + ",IdTipoPersona=" + idTipoPersona + ",NroDocIdentidad='" + nDocIdentidad + "'," +
                "NumeroRuc='" + numeroRuc + "',RazonSocial='" + razonSocial + "',NombreComercial='" + nombreComercial + "',Nombres='" + nombre + "',ApellidoPaterno='" + paterno + "'," +
                "ApellidoMaterno = '" + materno + "',Correo = '" + correo + "',Direccion = '" + direccion + "',Fax = '" + fax + "'," +
                "Fijo ='" + fijo + "',Telefono ='" + telefono + "',FechaNacimiento =" + fechaNacimiento + ",Departamento ='" + depa + "',Provincia ='" + provi + "'," +
                "Distrito = '" + distri + "',UsuarioRegistra = " + usuarioRegistra + ",FechaRegistro =" + fechaRegistro + ",UsuarioModifica =" + usuarioModifica + ",FechaModifica =" + fechaModifica + "," +
                "IdSector ='" + idSector + "',Observacion ='" + observacion + "' where IdClienteReceptor =" + idRecpCliente + "";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        //ELIMINAR CLIENTE
        public void EliminarCliente(String idRecpCliente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = " delete from Caja.ClienteReceptor where IdClienteReceptor=" + idRecpCliente + "";
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
        public SqlDataAdapter CargaClienteRedeptor()
        {
            String sql = "select top 100 di.Descripcion as Documento, (cr.NroDocumento) as DNI, cr.RUC, cr.Nombres, (cr.ApellidoPaterno +' '+cr.ApellidoMaterno) as Apellidos, cr.NombreEmpresa, cr.TipoCliente, s.DescripcionSector as Sector from  Caja.CLIENTE cr left join Caja.SECTOR s on cr.IdSector=s.IdSector left join dbo.TIPO_DOC_IDENT di on cr.IdTipoDocIdent =di.IdTipoDocIdent order by cr.IdCliente desc;";
            adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
            return adapter;

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
