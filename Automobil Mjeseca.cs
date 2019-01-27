using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class form_AutomobilMjeseca : Form
    {
        public form_AutomobilMjeseca()
        {
            InitializeComponent();
            pregled_auta kek = new pregled_auta();
            textBox1.Text = kek.naziv();
            textBox2.Text = kek.cijena().ToString();
        }

        private void lbl_Cijena_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pregled_auta alen = new pregled_auta();
            Process.Start(alen.link());
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
            new form_Izbornik().Show();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
