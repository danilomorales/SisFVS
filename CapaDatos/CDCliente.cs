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
        CDConexion objSql = new CDConexion();
        string strError = "";

        public string deverror()
        {
            return strError;
        }

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
            String sql = "Caja.SP_FE_MostrarCliente";
            adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
            return adapter;
        }

        //INSERTAR CLIENTE
        public void InsertarCliente(string idTienda, string idSector, string nombre, string apellidoP, string apellidoM, string nombreEmpre,
            string direccion, string contacto, string telefono, string fax, string ruc, string email,int idtipoPersona, string idtipoDocIdent, 
            string nroDocumento, string observacion, string inscripcion, string fechaNac,double credito, string tipoCliente, string depa,
            string provi, string distri, string usuRegistra)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Caja.SP_FE_InsertarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idTienda", idTienda);
            comando.Parameters.AddWithValue("@idSector", idSector);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellidoP", apellidoP);
            comando.Parameters.AddWithValue("@apellidoM", apellidoM);
            comando.Parameters.AddWithValue("@nombreEmpre", nombreEmpre);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@contacto", contacto);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@fax", fax);
            comando.Parameters.AddWithValue("@ruc", ruc);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@idtipoPersona", idtipoPersona);
            comando.Parameters.AddWithValue("@idtipoDocIdent", idtipoDocIdent);
            comando.Parameters.AddWithValue("@nroDocumento", nroDocumento);
            comando.Parameters.AddWithValue("@observacion", observacion);
            comando.Parameters.AddWithValue("@inscripcion", inscripcion);
            comando.Parameters.AddWithValue("@fechaNac", fechaNac);
            comando.Parameters.AddWithValue("@credito", credito);
            comando.Parameters.AddWithValue("@tipoCliente", tipoCliente);
            comando.Parameters.AddWithValue("@depa", depa);
            comando.Parameters.AddWithValue("@provi", provi);
            comando.Parameters.AddWithValue("@distri", distri);
            comando.Parameters.AddWithValue("@usuRegistra", usuRegistra);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //EDITAR CLIENTE
        public void EditarCliente(string idTienda, string idSector, string nombre, string apellidoP, string apellidoM, string nombreEmpre,
            string direccion, string contacto, string telefono, string fax, string ruc, string email, int idtipoPersona, string idtipoDocIdent,
            string nroDocumento, string observacion, string inscripcion, string fechaNac, double credito, string tipoCliente, string depa,
            string provi, string distri, string usuRegistra,string usuModifica,string fechaModifica, string idCliente)
        {
            Console.WriteLine("id cliente" + idCliente);
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "Caja.SP_FE_EditarCliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idTienda", idTienda);
                comando.Parameters.AddWithValue("@idSector", idSector);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellidoP", apellidoP);
                comando.Parameters.AddWithValue("@apellidoM", apellidoM);
                comando.Parameters.AddWithValue("@nombreEmpre", nombreEmpre);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@contacto", contacto);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@fax", fax);
                comando.Parameters.AddWithValue("@ruc", ruc);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@idtipoPersona", idtipoPersona);
                comando.Parameters.AddWithValue("@idtipoDocIdent", idtipoDocIdent);
                comando.Parameters.AddWithValue("@nroDocumento", nroDocumento);
                comando.Parameters.AddWithValue("@observacion", observacion);
                comando.Parameters.AddWithValue("@inscripcion", inscripcion);
                comando.Parameters.AddWithValue("@fechaNac", fechaNac);
                comando.Parameters.AddWithValue("@credito", credito);
                comando.Parameters.AddWithValue("@tipoCliente", tipoCliente);
                comando.Parameters.AddWithValue("@depa", depa);
                comando.Parameters.AddWithValue("@provi", provi);
                comando.Parameters.AddWithValue("@distri", distri);
                comando.Parameters.AddWithValue("@usuRegistra", usuRegistra);
                comando.Parameters.AddWithValue("@usuModifica", usuModifica);
                comando.Parameters.AddWithValue("@fechaModifica", fechaModifica);
                comando.Parameters.AddWithValue("@idCliente", idCliente);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("VIENE DEL CD" + ex);
            }

        }

        //ELIMINAR CLIENTE
        public void EliminarCliente(string idcliente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Caja.SP_FE_EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idcliente", idcliente);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
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

        //Filtrar Persona
        public List<String> filtroClienteEmpresa()
        {
            List<String> Lista = new List<string>();
            SqlConnection sqlCon;
            try
            {
                sqlCon = conexion.AbrirConexion();
   
                SqlCommand cmd = new SqlCommand("SELECT NombreEmpresa from Caja.CLIENTE", sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Lista.Add(reader.GetString(0));
                }
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al filtrar cliente" + ex);
            }

                return Lista;

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

        //public SqlDataAdapter CargaClienteRedeptor()
        //{
        //    String sql = "select cr.IdCliente, di.Descripcion as Documento, (cr.NroDocumento) as DNI, cr.RUC, cr.Nombres, (cr.ApellidoPaterno +' '+cr.ApellidoMaterno) as Apellidos, cr.NombreEmpresa, s.DescripcionSector as Sector from  Caja.CLIENTE cr left join Caja.SECTOR s on cr.IdSector=s.IdSector left join Caja.TIPO_DOC_IDENT di on cr.IdTipoDocIdent =di.IdTipoDocIdent order by cr.IdCliente desc;";
        //    adapter = new SqlDataAdapter(sql, conexion.AbrirConexion());
        //    return adapter;

        //}

        //Busca Clientes en Textbox

        public CECliente BuscarCliente(int id_Cli, String nro_Doc)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            CECliente c = null;
            try
            {
                SqlConnection cn = CDConexion.Instancia.AbrirConexion();
                cmd = new SqlCommand("Caja.SP_FE_BuscarCliente", cn);
                cmd.Parameters.AddWithValue("@prmidCliente", id_Cli);
                cmd.Parameters.AddWithValue("@prmNroDoc", nro_Doc);
                cmd.CommandType = CommandType.StoredProcedure;
                
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = new CECliente();
                    //c.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                    c.Id_Cliente = dr["IdCliente"].ToString();
                    c.Documento = dr["Documento"].ToString();
                    c.DNI = dr["DNI"].ToString();
                    c.RUC = dr["RUC"].ToString();
                    c.Nombres = dr["Nombres"].ToString();
                    c.Apellidos = dr["Apellidos"].ToString();
                    c.Nombre_Empresa = dr["Razón_Social"].ToString();
                    c.Sector = dr["Sector"].ToString();
                    //c.IdPrecio = dr["IdPrecio"].ToString();


                }
                cn.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return c;
        }
        //Buscar cliente por empresa
        public CECliente BuscarClienteEmpresa(int id_Cli, String empresa)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            CECliente c = null;
            try
            {
                SqlConnection cn = CDConexion.Instancia.AbrirConexion();
                cmd = new SqlCommand("Caja.SP_FE_BuscarClienteEmpresa", cn);
                cmd.Parameters.AddWithValue("@prmidCliente", id_Cli);
                cmd.Parameters.AddWithValue("@prmEmpresa", empresa);
                cmd.CommandType = CommandType.StoredProcedure;
                
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = new CECliente();
                    //c.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                    c.Id_Cliente = dr["IdCliente"].ToString();
                    c.Documento = dr["Documento"].ToString();
                    c.DNI = dr["DNI"].ToString();
                    c.RUC = dr["RUC"].ToString();
                    c.Nombres = dr["Nombres"].ToString();
                    c.Apellidos = dr["Apellidos"].ToString();
                    c.Nombre_Empresa = dr["Razón_Social"].ToString();
                    c.Sector = dr["Sector"].ToString();
                    //c.IdPrecio = dr["IdPrecio"].ToString();


                }
                cn.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return c;
        }

        public List<CECliente> ListaCLienteVenta()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<CECliente> Lista = null;
            
            try
            {
                SqlConnection cn = CDConexion.Instancia.CerrarConexion();
                cmd = new SqlCommand("Caja.SP_FE_ListaCliente_Venta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<CECliente>();
                while (dr.Read())
                {

                    CECliente c = new CECliente();
                   // c.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                    c.Documento = dr["Documento"].ToString();
                    c.DNI = dr["DNI"].ToString();
                    c.RUC = dr["RUC"].ToString();
                    c.Nombres = dr["Nombres"].ToString();
                    c.Apellidos = dr["Apellidos"].ToString();
                    c.Nombre_Empresa = dr["Razón_Social"].ToString();
                    c.Sector = dr["Sector"].ToString();
                    c.Id_Cliente = dr["IdCliente"].ToString();
                    Lista.Add(c);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public List<CECliente> BuscarClienteAvanzada(int tip_entrada, String valor_entrada)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<CECliente> Lista = null;
            try
            {
                SqlConnection cn = CDConexion.Instancia.CerrarConexion();
                cmd = new SqlCommand("Caja.SP_FE_BuscaClienteAvanzado", cn);
                cmd.Parameters.AddWithValue("@prmTipEntrada", tip_entrada);
                cmd.Parameters.AddWithValue("@prmValorEntrada", valor_entrada);

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<CECliente>();
                while (dr.Read())
                {
                    CECliente c = new CECliente();
                    c.Documento = dr["Documento"].ToString();
                    c.DNI = dr["DNI"].ToString();
                    c.RUC = dr["RUC"].ToString();
                    c.Nombres = dr["Nombres"].ToString();
                    c.Apellidos = dr["Apellidos"].ToString();
                    c.Nombre_Empresa = dr["Razón_Social"].ToString();
                    c.Sector = dr["Sector"].ToString();
                    Lista.Add(c);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }
        public DataTable LlenaEntidad_Cliente(string vIdCliente)
        {
            DataSet dst = new DataSet();
            DataTable dTabla = new DataTable();
            SqlConnection cnx = new SqlConnection();
            SqlParameter dPar = new SqlParameter();
            SqlDataAdapter dap = new SqlDataAdapter();
            try
            {
                cnx = objSql.AbrirConexion();
                dap = new SqlDataAdapter("Caja.SP_FE_CargaClienteVenta", cnx);
                dap.SelectCommand.CommandType = CommandType.StoredProcedure;

                dPar = dap.SelectCommand.Parameters.Add("@vIdCliente", SqlDbType.Int);
                dPar.Value = vIdCliente;
                dPar.Direction = ParameterDirection.Input;

                dap.Fill(dst, "IdCliente");
                dTabla = dst.Tables[0];

            }
            catch (Exception Ex)
            {
                strError = Ex.Message;
                dTabla.Clear();
            }
            finally
            {
                cnx.Close();
            }
            return dTabla;
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