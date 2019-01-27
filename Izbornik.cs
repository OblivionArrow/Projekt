using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class form_Izbornik : Form
    {
        public form_Izbornik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new form_NajnovijiAutomobil().Show();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new form_Konfigurator().Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            pregled_auta kek = new pregled_auta();
            kek.izracunaj_ocjenu();
            this.Close();
            new form_AutomobilMjeseca().Show();
        }
    }
}
 