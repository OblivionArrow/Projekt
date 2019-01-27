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
        DB baza = new DB();
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

            string Query = "select * from recenzija WHERE id_automobila ='" + id_auto + "'";
            MessageBox.Show(Query);
            dataGridView1.DataSource = baza.LoadDataBase(Query);
            // 
            /*
            string constring = "  DATA SOURCE = ROBIIIIIIIIIIIIIII.db";
            SQLiteConnection conDataBase = new SQLiteConnection(constring);
            string Query = "select ocjena, komentar from recenzija WHERE id_automobila ='" + id_auto + "'";
            SQLiteDataAdapter data = new SQLiteDataAdapter(Query, conDataBase);
            conDataBase.Open();
            DataTable table = new DataTable();
            data.Fill(table);
            conDataBase.Close();
            this.dataGridView1.DataSource = table;
            */
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.google.com");
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
                string Query2 = "INSERT INTO recenzija (id_automobila, ocjena, komentar) VALUES ('" + id_auto + "', '" + comboBox1.Text + "', '" + textBox7.Text + "')";
                MessageBox.Show(Query2);
                baza.Query(Query2);
                
                /*
             string constring = "  DATA SOURCE = ROBIIIIIIIIIIIIIII.db";
             SQLiteConnection con = new SQLiteConnection(constring);
                 con.Open();
             string Query = "INSERT INTO recenzija (id_automobila, ocjena, komentar) VALUES ('" + id_auto + "', '" + comboBox1.Text + "', '" + textBox7.Text + "')";
             SQLiteCommand cmd = new SQLiteCommand(Query, con);

             cmd.ExecuteNonQuery();

             con.Close();
             */
                MessageBox.Show("Poslan je komentar!");

            }
            string Query = "select ocjena, komentar from recenzija WHERE id_automobila ='" + id_auto + "'";
            dataGridView1.DataSource = baza.LoadDataBase(Query);
            /*
            string constring2 = "  DATA SOURCE = ROBIIIIIIIIIIIIIII.db";
            SQLiteConnection con2 = new SQLiteConnection(constring2);
            con2.Open();
            DataSet ds = new DataSet(); 
            DataTable dt = new DataTable();
            string Query2 = "select ocjena, komentar from recenzija WHERE id_automobila ='" + id_auto + "'";
            SQLiteDataAdapter da = new SQLiteDataAdapter(Query2, con2);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con2.Close();
            */

        }

        private void pregled_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
