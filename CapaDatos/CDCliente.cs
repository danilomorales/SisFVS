using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;

namespace CapaDatos
{
    public class CDCliente
    {
        private static readonly CDCliente _intancia = new CDCliente();
        public static CDCliente Intancia
        {
            get { return CDCliente._intancia; }
        }
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
            String sql = "select c.IdCliente,c.Nombres,c.ApellidoPaterno,c.ApellidoMaterno,t.NombreTienda as 'Nombre de la Tienda'," +
                "s.DescripcionSector as 'Nombre del sector',c.NombreEmpresa as 'Nombre de la Empresa',c.Direccion," +
                "c.Contacto as 'Nombre del Contacto',c.Telefono,c.Fax,c.RUC,c.Email as 'Correo',d.Descripcion 'Documento'," +
                "c.NroDocumento as 'Nr° del Documento',c.Observacion as 'Observación',c.Departamento,c.Provincia,c.Distrito," +
                "c.UsuarioRegistra as'Usuario que Registra',c.Inscripcion as 'Inscripción',c.Estado,c.SaldoCtaCte as 'Cuenta Corriente',c.Nivel," +
                "c.FechaNac as 'Fecha de Nacimiento',c.TipoCompra as 'Tipo de Compra',c.Credito,c.Queja,c.EstSaldoIni as 'Estado Inicial'," +
                "c.OrdenCliente as 'Orden del Cliente',c.PromedioDeVentas as 'Promedio de ventas'," +
                "c.cta_cli,c.UsuarioModifica,c.FechaModifica from caja.CLIENTE c, dbo.TIENDA t, dbo.SECTOR s, dbo.TIPO_DOC_IDENT d " +
                "where c.IdTienda = t.IdTienda AND c.IdSector = s.IdSector and c.IdTipoDocIdent = d.IdTipoDocIdent; ";
            adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
            return adapter;
        }

        //INSERTAR CLIENTE
        public void InsertarCliente(String idTienda,String idSector,String nombreEmpresa,String nombres,String apellidoP, String apellidoM,
            String direccion,String contacto, String telefono,String fax,String ruc,String correo, String idTipoDoc,String nroDoc,String observacion,
            String inscripcion,double salCta, String fechaNac, String tipoCompra, double credito,String queja,int ordenclie,double promedioVentas,
            String cta_cli,String depa,String provi,String distri,String usuRegistra)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Caja.CLIENTE(IdTienda,IdSector,NombreEmpresa,Nombres,ApellidoPaterno,ApellidoMaterno,Direccion,Contacto," +
                "Telefono,Fax,RUC,Email,IdTipoDocIdent,NroDocumento,Observacion,Inscripcion,Estado,SaldoCtaCte,Nivel,FechaNac,TipoCompra,Credito,Queja," +
                "EstSaldoIni,OrdenCliente,TipoCliente,PromedioDeVentas,cta_cli,Departamento,Provincia,Distrito,UsuarioRegistra,UsuarioModifica," +
                "FechaModifica)values('"+ idTienda + "', '"+ idSector + "', '"+ nombreEmpresa + "', '"+ nombres + "', '"+ apellidoP + "', '"+ apellidoM + "'," +
                " '"+ direccion + "', '"+ contacto + "', '"+ telefono + "','"+ fax + "', '"+ ruc + "', '"+ correo + "', '"+ idTipoDoc + "', '"+ nroDoc + "'," +
                " '"+ observacion + "', '"+ inscripcion + "', 'A', '"+ salCta + "', '1','"+ fechaNac + "', '"+ tipoCompra + "','"+ credito + "', " +
                "'"+ queja + "', '1', '"+ ordenclie + "', '', '"+ promedioVentas + "', '"+ cta_cli + "', '"+ depa + "', '"+ provi + "', '"+ distri + "'," +
                " '"+ usuRegistra + "','', '')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        
        //EDITAR CLIENTE
        public void EditarCliente(String idCliente,String idTienda, String idSector, String nombreEmpresa, String nombres, String apellidoP, String apellidoM,
            String direccion, String contacto, String telefono, String fax, String ruc, String correo, String idTipoDoc, String nroDoc, String observacion,
            String inscripcion, double salCta, String fechaNac, String tipoCompra, double credito, String queja, int ordenclie, double promedioVentas,
            String cta_cli, String depa, String provi, String distri, String usuRegistra,String usuModifica,String fechaModi)
        {
            Console.WriteLine("id cliente" + idCliente);
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "update caja.CLIENTE set IdTienda='" + idTienda + "',IdSector='" + idSector + "',NombreEmpresa='" + nombreEmpresa + "',Nombres='" + nombres + "'," +
                    "ApellidoPaterno = '" + apellidoP + "',ApellidoMaterno = '" + apellidoM + "',Direccion = '" + direccion + "',Contacto = '" + contacto + "',Telefono = '" + telefono + "'," +
                    "Fax = '" + fax + "',RUC = '" + ruc + "',Email = '" + correo + "',IdTipoDocIdent = '" + idTipoDoc + "',NroDocumento = '" + nroDoc + "',Observacion = '" + observacion + "'," +
                    "Inscripcion = " + inscripcion + ",Estado = 'A',SaldoCtaCte = " + salCta + ",Nivel = '1',FechaNac = " + fechaNac + ",TipoCompra = '" + tipoCompra + "',Credito =" + credito + "," +
                    "Queja = '" + queja + "',EstSaldoIni = '1',OrdenCliente = " + ordenclie + ",TipoCliente = '',PromedioDeVentas = " + promedioVentas + " ,cta_cli = '" + cta_cli + "'," +
                    "Departamento = '" + depa + "',Provincia = '" + provi + "',Distrito = '" + distri + "',UsuarioRegistra = '" + usuRegistra + "',UsuarioModifica = '" + usuModifica + "'," +
                    "FechaModifica = " + fechaModi + " where IdCliente = '" + idCliente + "'";
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch(SqlException ex)
            {
                Console.WriteLine("VIENE DEL CD" + ex);
            }
           
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
            comando.CommandText = "select * from Caja.TIPO_DOC_IDENT";
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

        //LLENAR COMBOBOX TIENDA
        public DataTable ListarTienda()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Caja.TIENDA";
            leer = comando.ExecuteReader();
            table.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return table;
        }

        public SqlDataAdapter CargaClienteRedeptor()
        {
            String sql = "select top 100 cr.IdCliente, di.Descripcion as Documento, (cr.NroDocumento) as DNI, cr.RUC, cr.Nombres, (cr.ApellidoPaterno +' '+cr.ApellidoMaterno) as Apellidos, cr.NombreEmpresa, s.DescripcionSector as Sector from  Caja.CLIENTE cr left join Caja.SECTOR s on cr.IdSector=s.IdSector left join dbo.TIPO_DOC_IDENT di on cr.IdTipoDocIdent =di.IdTipoDocIdent order by cr.IdCliente desc;";
            adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
            return adapter;

        }

        //Busca Clientes en Textbox

        public CECliente BuscarCliente(int id_Cli, String nro_Doc)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            CECliente c = null;
            try
            {
                SqlConnection cn = CDConexion.Instancia.CerrarConexion();
                cmd = new SqlCommand("Caja.SP_FE_BuscarCliente", cn);
                cmd.Parameters.AddWithValue("@prmidCliente", id_Cli);
                cmd.Parameters.AddWithValue("@prmNroDoc", nro_Doc);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = new CECliente();
                    c.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                    c.Documento = dr["Documento"].ToString();
                    c.DNI = dr["DNI"].ToString();
                    c.RUC = dr["RUC"].ToString();
                    c.Nombres= dr["Nombres"].ToString();
                    c.Apellidos= dr["Apellidos"].ToString();
                    c.Nombre_Empresa = dr["NombreEMPRESA"].ToString();
                    c.Sector = dr["Sector"].ToString();
                    c.IdPrecio = dr["IdPrecio"].ToString();
                    

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return c;
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
