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
    public partial class form_Konfigurator : Form
    {
        public form_Konfigurator()
        {
            InitializeComponent();
            Combo_vrsta();
            Combo_marka();
            Combo_model();
            Combo_gorivo();
            Combo_mjenjac();
            Combo_oprema();


        }
        void Combo_vrsta()
        {
            string constring = "  DATA SOURCE = ROBIIIIIIIIIIIIIII.db";
            string Query = "select * from vrsta_auto";
            SQLiteConnection conDataBase = new SQLiteConnection(constring);
            SQLiteCommand cmdDataBase = new SQLiteCommand(Query, conDataBase);
            SQLiteDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader["naziv"].ToString();
                    cobx_Vrsta.Items.Add(sName);    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }                     


        void Combo_marka()
        {
            string constring = "  DATA SOURCE = ROBIIIIIIIIIIIIIII.db";
            string Query = "select * from marka";
            SQLiteConnection conDataBase = new SQLiteConnection(constring);
            SQLiteCommand cmdDataBase = new SQLiteCommand(Query, conDataBase);
            SQLiteDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader["naziv"].ToString();
                    cobx_Marka.Items.Add(sName);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
                              

        void Combo_model()
        {
            string constring = "  DATA SOURCE = ROBIIIIIIIIIIIIIII.db";
            string Query = "select * from model";
            SQLiteConnection conDataBase = new SQLiteConnection(constring);
            SQLiteCommand cmdDataBase = new SQLiteCommand(Query, conDataBase);
            SQLiteDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader["naziv"].ToString();
                    cobx_Model.Items.Add(sName);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        void Combo_gorivo()
        {
            string constring = "  DATA SOURCE = ROBIIIIIIIIIIIIIII.db";
            string Query = "select * from gorivo";
            SQLiteConnection conDataBase = new SQLiteConnection(constring);
            SQLiteCommand cmdDataBase = new SQLiteCommand(Query, conDataBase);
            SQLiteDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader["naziv"].ToString();
                    cobx_Gorivo.Items.Add(sName);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
               
        
        void Combo_mjenjac()
        {
            string constring = "  DATA SOURCE = ROBIIIIIIIIIIIIIII.db";
            string Query = "select * from mjenjac";
            SQLiteConnection conDataBase = new SQLiteConnection(constring);
            SQLiteCommand cmdDataBase = new SQLiteCommand(Query, conDataBase);
            SQLiteDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader["naziv"].ToString();
                    cobx_Mjenjač.Items.Add(sName);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        void Combo_oprema()
        {
            string constring = "  DATA SOURCE = ROBIIIIIIIIIIIIIII.db";
            string Query = "select * from paketopreme";
            SQLiteConnection conDataBase = new SQLiteConnection(constring);
            SQLiteCommand cmdDataBase = new SQLiteCommand(Query, conDataBase);
            SQLiteDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader["naziv"].ToString();
                    cobx_Oprema.Items.Add(sName);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




        private void Konfigurator_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            form_Izbornik fi = new form_Izbornik();
            fi.ShowDialog();
        }

        

        private void VrstaAut_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void VrsteA_Click(object sender, EventArgs e)
        {

        }

        private void cobx_Marka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Model_Click(object sender, EventArgs e)
        {

        }

        private void cobx_Model_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Gorivo_Click(object sender, EventArgs e)
        {

        }

        private void cobx_Gorivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Mjenjač_Click(object sender, EventArgs e)
        {

        }

        private void cobx_Mjenjač_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Oprema_Click(object sender, EventArgs e)
        {

        }

        private void cobx_Oprema_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) 
        {
            if (string.IsNullOrEmpty(cobx_Vrsta.Text))
            {
                MessageBox.Show("Niste odabrali sva polja!");
            }

            else if (string.IsNullOrEmpty(cobx_Marka.Text)) 
            {
                MessageBox.Show("Niste odabrali sva polja!");
            }

            else if (string.IsNullOrEmpty(cobx_Model.Text))
            {
                MessageBox.Show("Niste odabrali sva polja!");
            }

            else if (string.IsNullOrEmpty(cobx_Oprema.Text))
            {
                MessageBox.Show("Niste odabrali sva polja!");
            }

            else if (string.IsNullOrEmpty(cobx_Mjenjač.Text))
            {
                MessageBox.Show("Niste odabrali sva polja!");
            }

            else if (string.IsNullOrEmpty(cobx_Gorivo.Text))
            {
                MessageBox.Show("Niste sva polja!");
            }

            else
            {

                int gorivo;
                int vrsta;
                int model;
                int mjenjac; 
                int oprema;
                int marka;

                string constring = "  DATA SOURCE = ROBIIIIIIIIIIIIIII.db";
                string Query = "SELECT id FROM vrsta_auto WHERE naziv  = '" + cobx_Vrsta.Text + "'";

                // selectamo ID pomocu stringa (naziva) iz comboboxa za svaku komponentu 


                SQLiteConnection conDataBase = new SQLiteConnection(constring);
                SQLiteCommand cmd = new SQLiteCommand(Query, conDataBase);
                conDataBase.Open();
                vrsta = Convert.ToInt32(cmd.ExecuteScalar());

                string query5 = "SELECT Id FROM marka WHERE naziv  = '" + cobx_Marka.Text + "'";
                cmd = new SQLiteCommand(query5, conDataBase);
                marka = Convert.ToInt32(cmd.ExecuteScalar());

                string query1 = "SELECT Id FROM model WHERE naziv  = '" + cobx_Model.Text + "'";
                cmd = new SQLiteCommand(query1, conDataBase);
                model = Convert.ToInt32(cmd.ExecuteScalar());

    
                string query2 = "SELECT Id FROM gorivo WHERE naziv  = '" + cobx_Gorivo.Text + "'";
                cmd = new SQLiteCommand(query2, conDataBase);
                gorivo = Convert.ToInt32(cmd.ExecuteScalar());
                

                string query3 = "SELECT Id FROM mjenjac WHERE naziv = '" + cobx_Mjenjač.Text + "'";
                cmd = new SQLiteCommand(query3, conDataBase);
                mjenjac = Convert.ToInt32(cmd.ExecuteScalar());

               
                string query4 = "SELECT Id FROM paketopreme WHERE naziv  = '" + cobx_Oprema.Text + "'";
                cmd = new SQLiteCommand(query4, conDataBase);
                oprema = Convert.ToInt32(cmd.ExecuteScalar());

                string query6 = "SELECT COUNT (*) FROM automobil WHERE id_vrste = '" + vrsta + "' AND id_marke = '" + marka +"' AND id_model = '" + model + "' AND id_goriva = '" + gorivo + "' AND id_mjenjac = '" + mjenjac + "' AND id_paketopreme = '" + oprema + "'";
                SQLiteDataAdapter data = new SQLiteDataAdapter(query6, conDataBase);
                DataTable table = new DataTable();
                data.Fill(table);

                // ako postoji auto

                if (table.Rows[0][0].ToString() == "1")
                {
                    // selektamo id_auta zbog sljedeceg prozora

                    string query7 = "SELECT Id FROM automobil WHERE id_vrste = '" + vrsta + "' AND id_marke = '" + marka + "' AND id_model = '" + model + "' AND id_goriva = '" + gorivo + "' AND id_mjenjac = '" + mjenjac + "' AND id_paketopreme = '" + oprema + "'";
                    cmd = new SQLiteCommand(query4, conDataBase);
                    int id_auto = Convert.ToInt32(cmd.ExecuteScalar());

                    string a1= cobx_Vrsta.Text;
                    string b1 = cobx_Marka.Text;
                    string c1 = cobx_Model.Text;
                    string d1 = cobx_Gorivo.Text;
                    string e1 = cobx_Mjenjač.Text;
                    string f1= cobx_Oprema.Text;

                    MessageBox.Show("AUTO JE PRONADEN");

                    this.Close();

                    new pregled(id_auto, a1, b1, c1, d1, e1, f1).Show();
                    

                    
                }

                else
                {
                    MessageBox.Show("Nije pronađen auto!");
                }

                
                





            }


        }
    }
}
