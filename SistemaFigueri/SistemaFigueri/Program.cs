using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFigueri
{
    static class Program
    {

        public static string IdProducto;
        public static String DescripcionProducto;
        public static String Alias;
        public static String Marca;
        public static Int32 Stock;
        public static Decimal PrecioVenta;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
