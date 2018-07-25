using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFigueri
{
    class LlenarItems
    {
        SqlConnection cnn;
        SqlCommand cmd;      
        SqlDataReader dr;

        public LlenarItems()
        {
            try
            {
                cnn = new SqlConnection("Data Source=192.168.21.5;Initial Catalog=DBFIGUE2;User ID=sa;Password=123");
                cnn.Open();
                //MessageBox.Show("Conectado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No Conectado:" +ex.ToString());
            }
            
        }

        //Listar Categoria en ComboBox
        public void llenarCategoria(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select Descripcion from dbo.CATEGORIA ", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Descripcion"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el comboBox: " + ex.ToString());
            }
        }

        //Listar Medida en ComboBox
        public void llenarMedida(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select Descripcion from dbo.MEDIDA ", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Descripcion"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el comboBox: " + ex.ToString());
            }
        }

        //Listar Tienda en ComboBox
        public void llenarTienda(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select NombreTienda from dbo.TIENDA ", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["NombreTienda"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el comboBox: " + ex.ToString());
            }
        }

        //Listar Sector en ComboBox
        public void llenarSector(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select DescripcionSector from dbo.SECTOR ", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["DescripcionSector"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el comboBox: " + ex.ToString());
            }
        }

        //Listar Tipo de Documento en ComboBox
        public void llenarTipoDoc(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select Descripcion from dbo.TIPO_DOC_IDENT ", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Descripcion"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el comboBox: " + ex.ToString());
            }
        }
    }

}
