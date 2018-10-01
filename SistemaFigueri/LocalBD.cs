using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaNegocio;
using System.Threading.Tasks;

namespace SistemaFigueri
{
   
    public class LocalBD
    {
        private static readonly LocalBD _intancia = new LocalBD();
        public static LocalBD Instancia
        {
            get { return LocalBD._intancia; }
        }
        int intento = 0;
        String IdProd = "0";
        string Iidcliente = "0";
        int invocador = 0; // 1: BOLETA, 2: NOTAVENTA, 3: FACT


        public String NumeroSerie { get; set; }
        List<CEProducto> detBoleta = new List<CEProducto>();
        List<CEProducto> detNotaVenta = new List<CEProducto>();
        public int Invocar(int getset, int frm)
        {
            try
            {
                if (getset == 1) invocador = frm;
            }
            catch (Exception)
            {
                throw;
            }
            return invocador;
        }
        public int ReturnIntento(int getset, int intent)
        {
            try
            {
                if (getset == 1)
                {
                    intento = intent;
                }
                return intento;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public string ReturnIdCliente(int getset, string idCliente)
        {
            try
            {
                if (getset == 1)
                {
                    Iidcliente = idCliente;
                }
                return Iidcliente;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public string ReturnIdprod(int getset, string idprod)
        {
            try
            {
                if (getset == 1)
                {
                    IdProd = idprod;
                }
                return IdProd;

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
