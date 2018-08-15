﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFigueri
{
    public class Venta
    {
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Descuento { get; set; }
        public decimal Igv { get; set; }
        public decimal SubTotal { get; set; }

        public Venta()
        {
            Cantidad = 0;
            Descripcion = "";
            PrecioVenta = 0;
            IdVenta = 0;
            IdProducto = 0;
            Igv = 0;
            SubTotal = 0;
            Descuento = "";

        }
        public Venta(int objIdVenta, int objCantidad, string objDescripcion, decimal objPVenta,
           int objIdProducto, decimal objIgv, decimal objSubTotal, string objDescuento)
        {
            IdVenta = objIdVenta;
            Cantidad = objCantidad;
            Descripcion = objDescripcion;
            PrecioVenta = objPVenta;
            IdProducto = objIdProducto;
            Igv = objIgv;
            SubTotal = objSubTotal;
            Descuento = objDescuento;
        }

    }

}