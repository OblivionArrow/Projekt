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

            // preduvjet za otvaranje konekcije prema bazi , select count gleda u tablici zaposlenik da li postoji zaposlenik sa usernamemom tim i tim
            string constring = "  DATA SOURCE = ROBIIIIIIIIIIIIIII.db";
            string Query = ("SELECT COUNT(*) FROM login WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'");
            SQLiteConnection conDataBase = new SQLiteConnection(constring);
            SQLiteCommand cmdDataBase = new SQLiteCommand(Query, conDataBase);
            SQLiteDataAdapter kek = new SQLiteDataAdapter(cmdDataBase);
            DataTable dt = new DataTable();

            kek.Fill(dt);
            
            // ukoliko postoji otvara sljedeci prozor

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Close();
            new form_Izbornik().Show();
            
            }

            else
            {
                MessageBox.Show("Username or password is incorrect!");
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

        private void form_Prijava_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
