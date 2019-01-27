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

            konf_combobox alen = new konf_combobox();
            string query = "vrsta_auto";
            var itemi = alen.popuni(query);
            cobx_Vrsta.DataSource = itemi; 

        }                     


        void Combo_marka()
        {
            konf_combobox alen = new konf_combobox();
            string query = "marka";
            var itemi = alen.popuni(query);
            cobx_Marka.DataSource = itemi;

        }
                              

        void Combo_model()
        {
            konf_combobox alen = new konf_combobox();
            string query = "model";
            var itemi = alen.popuni(query);
            cobx_Model.DataSource = itemi;

        }


        void Combo_gorivo()
        {
            konf_combobox alen = new konf_combobox();
            string query = "gorivo";
            var itemi = alen.popuni(query);
            cobx_Gorivo.DataSource = itemi;

        }
               
        
        void Combo_mjenjac()
        {
            konf_combobox alen = new konf_combobox();
            string query = "mjenjac";
            var itemi = alen.popuni(query);
            cobx_Mjenjač.DataSource = itemi;

        }



        void Combo_oprema()
        {
            konf_combobox alen = new konf_combobox();
            string query = "paketopreme";
            var itemi = alen.popuni(query);
            cobx_Oprema.DataSource = itemi;

        }




        private void Konfigurator_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
            new form_Izbornik().Show();
            
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
               
                konf_combobox xyz = new konf_combobox();
                int id_auto = xyz.query_tablice(cobx_Vrsta.Text, cobx_Marka.Text, cobx_Model.Text, cobx_Gorivo.Text, cobx_Mjenjač.Text, cobx_Oprema.Text);
                if (id_auto != 0)
                {
                    
                    string a1= cobx_Vrsta.Text;
                    string b1 = cobx_Marka.Text;
                    string c1 = cobx_Model.Text;
                    string d1 = cobx_Gorivo.Text;
                    string e1 = cobx_Mjenjač.Text;
                    string f1= cobx_Oprema.Text;
                    
                    this.Close();
                    new pregled(id_auto, a1, b1, c1, d1, e1, f1).Show();
                }

      

            }


        }
    }
}
