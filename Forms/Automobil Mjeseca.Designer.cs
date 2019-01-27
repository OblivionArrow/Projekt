namespace WindowsFormsApp2
{
    partial class form_AutomobilMjeseca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_AutomobilMjeseca));
            this.lbl_Audi = new System.Windows.Forms.Label();
            this.lbl_Cijena = new System.Windows.Forms.Label();
            this.lbl_Link1 = new System.Windows.Forms.LinkLabel();
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Audi
            // 
            this.lbl_Audi.AutoSize = true;
            this.lbl_Audi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Audi.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Audi.Location = new System.Drawing.Point(304, 19);
            this.lbl_Audi.Name = "lbl_Audi";
            this.lbl_Audi.Size = new System.Drawing.Size(239, 69);
            this.lbl_Audi.TabIndex = 0;
            this.lbl_Audi.Text = "Audi A7";
            this.lbl_Audi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Cijena
            // 
            this.lbl_Cijena.AutoSize = true;
            this.lbl_Cijena.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cijena.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Cijena.Location = new System.Drawing.Point(195, 105);
            this.lbl_Cijena.Name = "lbl_Cijena";
            this.lbl_Cijena.Size = new System.Drawing.Size(447, 55);
            this.lbl_Cijena.TabIndex = 16;
            this.lbl_Cijena.Text = "Već od: 629,186 Kn";
            this.lbl_Cijena.Click += new System.EventHandler(this.lbl_Cijena_Click);
            // 
            // lbl_Link1
            // 
            this.lbl_Link1.AutoSize = true;
            this.lbl_Link1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Link1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Link1.LinkColor = System.Drawing.Color.DarkRed;
            this.lbl_Link1.Location = new System.Drawing.Point(12, 369);
            this.lbl_Link1.Name = "lbl_Link1";
            this.lbl_Link1.Size = new System.Drawing.Size(330, 55);
            this.lbl_Link1.TabIndex = 17;
            this.lbl_Link1.TabStop = true;
            this.lbl_Link1.Text = "Saznajte Više!";
            this.lbl_Link1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lbl_Link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Link1_LinkClicked);
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.BackColor = System.Drawing.Color.Red;
            this.btn_Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nazad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Nazad.Location = new System.Drawing.Point(704, 12);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(84, 33);
            this.btn_Nazad.TabIndex = 18;
            this.btn_Nazad.Text = "Nazad";
            this.btn_Nazad.UseVisualStyleBackColor = false;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // form_AutomobilMjeseca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.lbl_Link1);
            this.Controls.Add(this.lbl_Cijena);
            this.Controls.Add(this.lbl_Audi);
            this.Name = "form_AutomobilMjeseca";
            this.Text = "Automobil Mjeseca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Audi;
        private System.Windows.Forms.Label lbl_Cijena;
        private System.Windows.Forms.LinkLabel lbl_Link1;
        private System.Windows.Forms.Button btn_Nazad;
    }
}