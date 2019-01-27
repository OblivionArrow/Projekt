namespace WindowsFormsApp2
{
    partial class form_NajnovijiAutomobil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_NajnovijiAutomobil));
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.lbl_Peugeot = new System.Windows.Forms.Label();
            this.lbl_Cijena = new System.Windows.Forms.Label();
            this.lbl_Link1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.BackColor = System.Drawing.Color.Red;
            this.btn_Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nazad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Nazad.Location = new System.Drawing.Point(704, 12);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(84, 33);
            this.btn_Nazad.TabIndex = 13;
            this.btn_Nazad.Text = "Nazad";
            this.btn_Nazad.UseVisualStyleBackColor = false;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // lbl_Peugeot
            // 
            this.lbl_Peugeot.AutoSize = true;
            this.lbl_Peugeot.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Peugeot.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Peugeot.Location = new System.Drawing.Point(145, 12);
            this.lbl_Peugeot.Name = "lbl_Peugeot";
            this.lbl_Peugeot.Size = new System.Drawing.Size(503, 69);
            this.lbl_Peugeot.TabIndex = 14;
            this.lbl_Peugeot.Text = "Novi Peugeot 508";
            // 
            // lbl_Cijena
            // 
            this.lbl_Cijena.AutoSize = true;
            this.lbl_Cijena.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cijena.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Cijena.Location = new System.Drawing.Point(181, 331);
            this.lbl_Cijena.Name = "lbl_Cijena";
            this.lbl_Cijena.Size = new System.Drawing.Size(447, 55);
            this.lbl_Cijena.TabIndex = 15;
            this.lbl_Cijena.Text = "Već od: 208,630 Kn";
            this.lbl_Cijena.Click += new System.EventHandler(this.lbl_Cijena_Click);
            // 
            // lbl_Link1
            // 
            this.lbl_Link1.AutoSize = true;
            this.lbl_Link1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Link1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Link1.LinkColor = System.Drawing.Color.DarkRed;
            this.lbl_Link1.Location = new System.Drawing.Point(236, 386);
            this.lbl_Link1.Name = "lbl_Link1";
            this.lbl_Link1.Size = new System.Drawing.Size(330, 55);
            this.lbl_Link1.TabIndex = 16;
            this.lbl_Link1.TabStop = true;
            this.lbl_Link1.Text = "Saznajte Više!";
            this.lbl_Link1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lbl_Link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Link1_LinkClicked);
            // 
            // form_NajnovijiAutomobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Link1);
            this.Controls.Add(this.lbl_Cijena);
            this.Controls.Add(this.lbl_Peugeot);
            this.Controls.Add(this.btn_Nazad);
            this.Name = "form_NajnovijiAutomobil";
            this.Text = "Najnoviji Automobil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Nazad;
        private System.Windows.Forms.Label lbl_Peugeot;
        private System.Windows.Forms.Label lbl_Cijena;
        private System.Windows.Forms.LinkLabel lbl_Link1;
    }
}