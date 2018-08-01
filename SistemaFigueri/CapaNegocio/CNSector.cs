using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CNSector
    {
        CDSector sec = new CDSector();

        //READALL SECTOR
        public DataTable MostarSector()
        {
            DataTable table = new DataTable();
            table = sec.listarSector();
            return table;
        }

        //CREATE SECTOR
        public void InsertSector(String descripcion, String nota)
        {
            Console.WriteLine("Sera pues ..." + descripcion + " " + nota);
           sec.InsertarSector( nota,descripcion);

        }

        //UPDATE SECTOR
        public void UpdateSector(String idSector, String descripcion, String nota)
        {
            Console.WriteLine("Sera pues ..." + idSector + " " + descripcion + " " + nota);
            sec.EditarSector(idSector, descripcion,nota);
        }

        //DELETE SECTOR
        public void DeleteSector(String idSector)
        {
            sec.EliminarSector(idSector);
        }
    }
}
