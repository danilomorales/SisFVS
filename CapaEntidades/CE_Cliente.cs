using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CE_Cliente
    {
        String idCliente;
        String idTipoDocIdent;
        String idSector;
        int idTipoPersona;
        String nombres;
        String apellidoPaterno;
        String apellidoMaterno;
        String nombreEmpresa;
        String direccion;
        String contacto;
        String fax;
        String rUC;
        String nroDocumento;
        String idUbigeo;
        String departamento;
        String provincia;
        String distrito;
        char estado;


        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string IdTipoDocIdent { get => idTipoDocIdent; set => idTipoDocIdent = value; }
        public string IdSector { get => idSector; set => idSector = value; }
        public int IdTipoPersona { get => idTipoPersona; set => idTipoPersona = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string Fax { get => fax; set => fax = value; }
        public string RUC { get => rUC; set => rUC = value; }
        public string NroDocumento { get => nroDocumento; set => nroDocumento = value; }
        public string IdUbigeo { get => idUbigeo; set => idUbigeo = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Distrito { get => distrito; set => distrito = value; }
        public char Estado { get => estado; set => estado = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
