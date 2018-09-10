using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
     public class CNSerie
    {
        CDSerie serie = new CDSerie();

        //READALL SERIE
        public SqlDataAdapter MostarSerie()
        {
            return serie.listarSerie();
        }

        //INSERT SERIE
        public void InsertSerie(string numeroserie, string fcorrelativo, string bcorrelativo, string nccorrelativo,
            string nccorrelativoBo, string nccorrelativoFac)
        {
            serie.InsertarSerie(numeroserie,Convert.ToInt32(fcorrelativo), Convert.ToInt32(bcorrelativo),
                Convert.ToInt32(nccorrelativo), Convert.ToInt32(nccorrelativoBo),
                Convert.ToInt32(nccorrelativoFac));
        }

        //UPDATE SERIE
        public void UpdateSerie(string numeroserie, string fcorrelativo, string bcorrelativo, string nccorrelativo,
            string nccorrelativoBo, string nccorrelativoFac,string idSerie)
        {
            serie.EditarSerie(numeroserie, Convert.ToInt32(fcorrelativo), Convert.ToInt32(bcorrelativo),
                Convert.ToInt32(nccorrelativo), Convert.ToInt32(nccorrelativoBo),
                Convert.ToInt32(nccorrelativoFac), Convert.ToInt32(idSerie));
        }

        //DELETE SERIE
        public void DeleteSerie(string idSerie)
        {
            serie.EliminarSerie(Convert.ToInt32(idSerie));
        }

    }
}
