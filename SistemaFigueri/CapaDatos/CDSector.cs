using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDSector
    {

        private CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        //LISTAR SECTOR
        public DataTable listarSector()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from caja.SECTOR";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //INSERTAR SECTOR
        public void InsertarSector(String descripcion, String nota,double porcentaje)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into caja.SECTOR(DescripcionSector,Nota,Porcentaje) values('" + descripcion + "','" + nota + "','" + porcentaje + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //EDITAR SECTOR
        public void EditarSector(String idSector, String descripcion, String nota, double porcentaje)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update caja.SECTOR set DescripcionSector='" + descripcion + "',Nota='" + nota + "',Porcentaje=" + porcentaje + " where IdSector='" + idSector + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
            comando.Parameters.Clear();
        }

        //ELIMINAR SECTOR
        public void EliminarSector(String idSector)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from caja.SECTOR where IdSector='" + idSector + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
