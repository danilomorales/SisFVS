using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CECliente
    {
        public int IdCliente { get; set; }
        public String IdSector { get; set; }
        public String Id_Cliente { get; set; }
        public String Documento { get; set; }
        public String DNI { get; set; }
        public String RUC { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Nombre_Empresa { get; set; }
        public String Sector { get; set; }
        public String IdPrecio { get; set; }
        int idTipoPersona;

        public int IdTipoPersona
        {
            get { return idTipoPersona; }
            set { idTipoPersona = value; }
        }
        String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        String telefono;

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        char estado;

        public char Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
