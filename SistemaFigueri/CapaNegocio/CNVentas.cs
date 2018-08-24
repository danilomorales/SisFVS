﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNVentas
    {
        CDConexion C = new CDConexion();
        public int IdUsuario { get; set; }
        public int IdClienteReceptor { get; set; }
        public int IdSerie { get; set; }
        public int IdTipoDoc { get; set; }
        public int NroDocumento { get; set; }
        public DateTime Fecha_Venta { get; set; }
        public decimal Total { get; set; }

   
        public String RegistrarVenta()
        {
            String Mensaje = "";
            List<clParametro> lst = new List<clParametro>();
            try
            {
                lst.Add(new clParametro("@IdUsuario", IdUsuario));
                lst.Add(new clParametro("@IdClienteReceptor", IdClienteReceptor));
                lst.Add(new clParametro("@IdSerie", IdSerie));
                lst.Add(new clParametro("@IdTipoDoc", IdTipoDoc));
                lst.Add(new clParametro("@NroDocumento", NroDocumento));
                lst.Add(new clParametro("@Fecha_Venta", Fecha_Venta));
                lst.Add(new clParametro("@Total", Total));
                lst.Add(new clParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
               // C.EjecutarSP("Caja.SP_RegistraVenta", ref lst);
                return Mensaje = lst[7].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       





    }
}
