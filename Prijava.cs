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
    public partial class form_Prijava : Form
    {
        public form_Prijava()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            login xy = new login();
            int id = xy.prijava(textBox1.Text, textBox2.Text);
            if (id == 1)
            {
                this.Close();
                new form_Izbornik().Show();
            }

            else
            {
                MessageBox.Show("Korisničko ime ili lozinka nisu točni!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
  
        private void btn_Registriraj2_Click(object sender, EventArgs e)
        {
           this.Close();
           new form_Registracija().Show();
           
        }

        private void txbx_Lozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_Prijava_Load(object sender, EventArgs e)
        {

        }
    }
}
