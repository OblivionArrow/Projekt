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
    public partial class form_Registracija : Form 
    {
        

        public form_Registracija()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Šifr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Korisničko_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // test
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }


            else {

                login xyz = new login();
                xyz.registracija(textBox1.Text, textBox2.Text, textBox3.Text);

                this.Close();
                new form_Prijava().Show();
           
            }
        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }

        private void txbx_Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
