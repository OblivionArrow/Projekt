using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp2
{
    class konf_combobox : DB
    {

        internal List<string> popuni(string a)
            {
                List<string> items = new List<string>();

                
                
                    string select_string = "SELECT * FROM '" + a + "'";
                    SQLiteCommand cmd = new SQLiteCommand(select_string, con);

                    
                    SQLiteDataReader myReader = cmd.ExecuteReader();

                    while (myReader.Read())
                    {
                        items.Add(myReader[1].ToString());
                    }

                    myReader.Close();
                

                return items;
            }


    public int query_tablice(string a, string b, string c, string d, string e, string f)
        {
            int gorivo;
            int vrsta;
            int model;
            int mjenjac;
            int oprema;
            int marka;
           

            
            

            // selectamo ID pomocu stringa (naziva) iz comboboxa za svaku komponentu 


            string Query = "SELECT id FROM vrsta_auto WHERE naziv  = '" + a + "'";
            SQLiteCommand cmd = new SQLiteCommand(Query, con);
            vrsta = Convert.ToInt32(cmd.ExecuteScalar());

            string query5 = "SELECT id FROM marka WHERE naziv  = '" + b + "'";
            cmd = new SQLiteCommand(query5, con);
            marka = Convert.ToInt32(cmd.ExecuteScalar());

            string query1 = "SELECT id FROM model WHERE naziv  = '" + c + "'";
            cmd = new SQLiteCommand(query1, con);
            model = Convert.ToInt32(cmd.ExecuteScalar());


            string query2 = "SELECT id FROM gorivo WHERE naziv  = '" + d + "'";
            cmd = new SQLiteCommand(query2, con);
            gorivo = Convert.ToInt32(cmd.ExecuteScalar());


            string query3 = "SELECT id FROM mjenjac WHERE naziv = '" + e + "'";
            cmd = new SQLiteCommand(query3, con);
            mjenjac = Convert.ToInt32(cmd.ExecuteScalar());


            string query4 = "SELECT id FROM paketopreme WHERE naziv  = '" + f + "'";
            cmd = new SQLiteCommand(query4, con);
            oprema = Convert.ToInt32(cmd.ExecuteScalar());

            string query6 = "SELECT COUNT (*) FROM automobil WHERE id_vrste = '" + vrsta + "' AND id_marke = '" + marka + "' AND id_model = '" + model + "' AND id_goriva = '" + gorivo + "' AND id_mjenjac = '" + mjenjac + "' AND id_paketopreme = '" + oprema + "'";
            SQLiteDataAdapter data = new SQLiteDataAdapter(query6, con);
            DataTable table = new DataTable();
            data.Fill(table);

            if (table.Rows[0][0].ToString() == "1")
            {
                // selektamo id_auta zbog sljedeceg prozora

                string query7 = "SELECT id FROM automobil WHERE id_vrste = '" + vrsta + "' AND id_marke = '" + marka + "' AND id_model = '" + model + "' AND id_goriva = '" + gorivo + "' AND id_mjenjac = '" + mjenjac + "' AND id_paketopreme = '" + oprema + "'";
                cmd = new SQLiteCommand(query7, con);
                int id_auto = Convert.ToInt32(cmd.ExecuteScalar());
                             
                return id_auto;
            }

            else
            {              
                MessageBox.Show("Ne postoji auto!");
                return 0;
            }

            

        }



    }
}
