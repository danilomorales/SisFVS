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
        int IdProd = 0;
        int Iidcliente = 0, idClienteNV = 0;
        int invocador = 0; // 1: BOLETA, 2: NOTAVENTA, 3: FACT
        private int _idsucrusal;
        public int IdSucursal
        {
            get { return _idsucrusal; }
            set { _idsucrusal = value; }
        }

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
        public int ReturnIdClienteNV(int getset, int idCliente)
        {
            try
            {
                if (getset == 1)
                {
                    idClienteNV = idCliente;
                }
                return idClienteNV;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public int ReturnIdCliente(int getset, int idCliente)
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
        public int ReturnIdprod(int getset, int idprod)
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

        public List<CEProducto> ReturnDetVenta(int getset, string Codigo, int cantidad)
        {
            try
            {
                if (getset == 1)
                {
                    if (cantidad > 1)
                    {
                        for (int i = 0; i < detBoleta.Count; i++)
                        {
                            if (detBoleta[i]._Codigo == Codigo)
                            {
                                detBoleta[i]._Cantidad = cantidad;
                                break;
                            }
                        }
                    }
                    else
                    {

                    //    for (int i = 0; i < detBoleta.Count; i++)
                    //    {
                    //        if (detBoleta[i]._Codigo == Codigo)
                    //        {
                    //            throw new ApplicationException("Este producto ya fue agreado");
                    //        }
                    //    }
                    //    CEProducto pr = CNProductos.Instancia.BuscarprodAvanzada(Codigo);
                    //    pr._Cantidad = cantidad;
                    //    detBoleta.Add(pr);
                    }
                }
                return detBoleta;
            }
            catch (Exception)
            {

                throw;
            }
        }
       
        public void QuitarItemPorducto(string IDProducto)
        {
            try
            {
                foreach (CEProducto p in detBoleta)
                {
                    if (p._Codigo == IDProducto)
                    {
                        detBoleta.Remove(p);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void QuitarItemPorductoNV(string Codigo)
        {
            try
            {
                foreach (CEProducto p in detNotaVenta)
                {
                    if (p._Codigo == Codigo)
                    {
                        detNotaVenta.Remove(p);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void LimpiarDetalleVenta()
        {
            try
            {
                detBoleta.RemoveRange(0, detBoleta.Count);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void LimpiarDetalNV()
        {
            try
            {
                detNotaVenta.RemoveRange(0, detNotaVenta.Count);
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
