using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CECaja
    {
        int idCaja;
        String tipoOper;
        string idSupervisor;
        int idCajero;
        String fechaOperacion;
        String glosa;
        String referencia;
        String tipodoc;
        decimal ingreso;
        decimal egreso;
        String voucher;
        String cta_cli;
        String cta_vnt;
        String nivel;
        String contabilizado;
        String nombre;
        //cajero datos
        String cajero;


        public int IdCaja { get => idCaja; set => idCaja = value; }
        public string TipoOper { get => tipoOper; set => tipoOper = value; }
        public string IdSupervisor { get => idSupervisor; set => idSupervisor = value; }
        public int IdCajero { get => idCajero; set => idCajero = value; }
        public string FechaOperacion { get => fechaOperacion; set => fechaOperacion = value; }
        public string Glosa { get => glosa; set => glosa = value; }
        public string Referencia { get => referencia; set => referencia = value; }
        public string Tipodoc { get => tipodoc; set => tipodoc = value; }
        public decimal Ingreso { get => ingreso; set => ingreso = value; }
        public decimal Egreso { get => egreso; set => egreso = value; }
        public string Voucher { get => voucher; set => voucher = value; }
        public string Cta_cli { get => cta_cli; set => cta_cli = value; }
        public string Cta_vnt { get => cta_vnt; set => cta_vnt = value; }
        public string Nivel { get => nivel; set => nivel = value; }
        public string Contabilizado { get => contabilizado; set => contabilizado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cajero { get => cajero; set => cajero = value; }
    }
}
