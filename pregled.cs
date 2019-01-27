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

namespace WindowsFormsApp2
{
    public partial class pregled : Form
    {

        public int id_auto;

        public pregled(int a, string a1, string b1, string c1, string d1, string e1, string f1)
        {
            InitializeComponent();
            id_auto = a;
            textBox1.Text = a1;
            textBox2.Text = b1;
            textBox3.Text = c1;
            textBox4.Text = d1;
            textBox5.Text = e1;
            textBox6.Text = f1;

            //ocjena
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");


          
            pregled_auta xyz = new pregled_auta();
            this.dataGridView1.DataSource = xyz.pregled(id_auto); 
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pregled_auta alen = new pregled_auta();
            Process.Start(alen.dohvatilink(id_auto));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Niste odabrali sva polja!");
            }

            else if(string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Niste odabrali sva polja!");
            }

            else {
             
                pregled_auta kek = new pregled_auta();
                kek.dodaj_komentar(id_auto, comboBox1.Text, textBox7.Text);

            }

            

        }

        private void pregled_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
            new form_Konfigurator().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
