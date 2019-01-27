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
        }

        private void lbl_Cijena_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.audi.hr/a7/a7-sportback/cijene");
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
            new form_Izbornik().Show();
            
        }
    }
}
