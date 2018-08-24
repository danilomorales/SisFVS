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
    public class CNSector
    {
        CDSector sec = new CDSector();

        //READALL SECTOR
        public SqlDataAdapter MostarSector()
        {
            return sec.listarSector();
        }

        //CREATE SECTOR
        public void InsertSector(String descripcion, String nota,String porcentaje)
        {
            Console.WriteLine("Sera pues ..." + descripcion + " " + nota+""+ porcentaje);
            sec.InsertarSector(nota, descripcion,Convert.ToDouble(porcentaje));

        }

        //UPDATE SECTOR
        public void UpdateSector(String idSector, String descripcion, String nota, String porcentaje)
        {
            Console.WriteLine("Sera pues ..." + idSector + " " + descripcion + " " + nota+"     "+ porcentaje);
            sec.EditarSector(idSector, descripcion, nota,Convert.ToDouble(porcentaje));
        }

        //DELETE SECTOR
        public void DeleteSector(String idSector)
        {
            sec.EliminarSector(idSector);
        }
    }
}
