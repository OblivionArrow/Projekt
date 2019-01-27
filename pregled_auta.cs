using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp2
{
    class pregled_auta : DB
    {

        public DataTable pregled(int id_auto)
        {
           
            string Query = "select ocjena, komentar from recenzija WHERE id_automobila ='" + id_auto + "'";
            SQLiteDataAdapter data = new SQLiteDataAdapter(Query, con);

            DataTable table = new DataTable();
            data.Fill(table);

            return table;
        }

        public void dodaj_komentar(int id_auto, string a, string b)
        {
            string Query = "INSERT INTO recenzija (id_automobila, ocjena, komentar) VALUES ('" + id_auto + "', '" + a + "', '" + b + "')";
            SQLiteCommand cmd = new SQLiteCommand(Query, con);

            cmd.ExecuteNonQuery();


            MessageBox.Show("Poslan je komentar!");

        }

        public void izracunaj_ocjenu()
        {

            int i = 1;
            float ocjena = 0;
            int maxid;


            string query = "SELECT MAX(Id_automobila) FROM recenzija";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            maxid = Convert.ToInt32(cmd.ExecuteScalar());


            for (int y = 0; y < maxid; y++) {

                
                //suma
                string query1 = "SELECT SUM(ocjena) FROM RECENZIJA WHERE Id_automobila = '" + i + "'";
                SQLiteCommand cmd1 = new SQLiteCommand(query1, con);
                object xyz = cmd1.ExecuteScalar();
                if(xyz != DBNull.Value)
                {
                   int count = Convert.ToInt32(cmd1.ExecuteScalar());

                // broji redove
                string query2 = "SELECT COUNT (*) FROM RECENZIJA WHERE Id_automobila = '" + i + "'";
                SQLiteCommand cmd2 = new SQLiteCommand(query2, con);
                int count1 = Convert.ToInt32(cmd2.ExecuteScalar());

                ocjena = count / count1;

                //update
                string query3 = "UPDATE automobil SET srednja_ocjena = '" + ocjena + "' WHERE id = '" + i + "'";
                SQLiteCommand cmd3 = new SQLiteCommand(query3, con);
                cmd3.ExecuteNonQuery();
                }

                else { 
                
                }
                
                i++;
            }

        }
        public string naziv()
        {

            string query = "SELECT MAX(srednja_ocjena) FROM automobil";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            int ocjena = Convert.ToInt32(cmd.ExecuteScalar());



            string query1 = "SELECT id_marke FROM automobil WHERE srednja_ocjena='" + ocjena + "'";
            SQLiteCommand cmd1 = new SQLiteCommand(query1, con);
            int id = Convert.ToInt32(cmd1.ExecuteScalar());


            string query2 = "SELECT naziv FROM marka WHERE id='" + id + "'";
            SQLiteCommand cmd2 = new SQLiteCommand(query2, con);
            string naziv = (string)cmd2.ExecuteScalar();




            return naziv;


        }

        public long cijena()
        {
            string query = "SELECT MAX(srednja_ocjena) FROM automobil";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            int ocjena = Convert.ToInt32(cmd.ExecuteScalar());

            string query1 = "SELECT ID FROM automobil WHERE srednja_ocjena='" + ocjena + "'";
            SQLiteCommand cmd1 = new SQLiteCommand(query1, con);
            int id = Convert.ToInt32(cmd1.ExecuteScalar());

            string query2 = "SELECT cijena FROM automobil WHERE id='" + id + "'";
            SQLiteCommand cmd2 = new SQLiteCommand(query2, con);
            long cijena = Convert.ToInt32(cmd2.ExecuteScalar());

            return cijena;
        }

        public string link()
        {
            string query = "SELECT MAX(srednja_ocjena) FROM automobil";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            int ocjena = Convert.ToInt32(cmd.ExecuteScalar());



            string query1 = "SELECT ID FROM automobil WHERE srednja_ocjena='" + ocjena + "'";
            SQLiteCommand cmd1 = new SQLiteCommand(query1, con);
            int id = Convert.ToInt32(cmd1.ExecuteScalar());

            string query2 = "SELECT link FROM automobil WHERE id='" + id + "'";
            SQLiteCommand cmd2 = new SQLiteCommand(query2, con);
            string link = (string)cmd2.ExecuteScalar();

            return link;
        }

        public string dohvatilink(int id)
        {
            string query1 = "SELECT link FROM automobil WHERE id='" + id + "'";
            SQLiteCommand cmd1 = new SQLiteCommand(query1, con);
            string link = (string)cmd1.ExecuteScalar();

            return link;
        }

      
    }
}
