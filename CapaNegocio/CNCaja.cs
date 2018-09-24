using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using CapaNegocio;

namespace CapaNegocio
{
    public class CNCaja
    {
        private static readonly CNCaja _intancia = new CNCaja();
        public static CNCaja Instancia
        {
            get { return CNCaja._intancia; }
        }
        private CDCaja caja = new CDCaja();


        public List<CECaja> ListaCaja()
        {
            try
            {
                List<CECaja> Lista = null;
                Lista = CDCaja.Instancia.ListaCajaApertura();
                if (Lista.Count == 0) throw new ApplicationException("Lista vacia");
                else if (Lista == null) throw new ApplicationException("Se produjo un error ");
                return Lista;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void InsertaIngresoEgreso_Caja(string TipoOper, string IdSupervisor, string IdCajero, string tipodoc, string Ingreso, string Egreso, string voucher)
        {
            Console.Write("se insertó" + TipoOper + " " + IdSupervisor + " " + IdCajero + " " + tipodoc + " " + Ingreso + " " + Egreso + " " + voucher);
            caja.InsertaCaja_Monto(TipoOper,IdSupervisor, IdCajero, tipodoc,Ingreso,Egreso,voucher);
          
        }

        

    }
}
