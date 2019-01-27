namespace WindowsFormsApp2
{
    partial class form_Konfigurator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Konfigurator));
            this.lbl_Vrsta = new System.Windows.Forms.Label();
            this.cobx_Vrsta = new System.Windows.Forms.ComboBox();
            this.cobx_Marka = new System.Windows.Forms.ComboBox();
            this.lbl_Marka = new System.Windows.Forms.Label();
            this.cobx_Model = new System.Windows.Forms.ComboBox();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.cobx_Oprema = new System.Windows.Forms.ComboBox();
            this.lbl_Oprema = new System.Windows.Forms.Label();
            this.cobx_Mjenjač = new System.Windows.Forms.ComboBox();
            this.lbl_Mjenjač = new System.Windows.Forms.Label();
            this.cobx_Gorivo = new System.Windows.Forms.ComboBox();
            this.lbl_Gorivo = new System.Windows.Forms.Label();
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Vrsta
            // 
            this.lbl_Vrsta.AutoSize = true;
            this.lbl_Vrsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vrsta.Location = new System.Drawing.Point(21, 66);
            this.lbl_Vrsta.Name = "lbl_Vrsta";
            this.lbl_Vrsta.Size = new System.Drawing.Size(243, 36);
            this.lbl_Vrsta.TabIndex = 0;
            this.lbl_Vrsta.Text = "Vrsta Automobila";
            this.lbl_Vrsta.Click += new System.EventHandler(this.VrsteA_Click);
            // 
            // cobx_Vrsta
            // 
            this.cobx_Vrsta.AccessibleName = "";
            this.cobx_Vrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobx_Vrsta.FormattingEnabled = true;
            this.cobx_Vrsta.Location = new System.Drawing.Point(27, 129);
            this.cobx_Vrsta.Name = "cobx_Vrsta";
            this.cobx_Vrsta.Size = new System.Drawing.Size(237, 24);
            this.cobx_Vrsta.TabIndex = 1;
            this.cobx_Vrsta.SelectedIndexChanged += new System.EventHandler(this.VrstaAut_SelectedIndexChanged);
            // 
            // cobx_Marka
            // 
            this.cobx_Marka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobx_Marka.FormattingEnabled = true;
            this.cobx_Marka.Location = new System.Drawing.Point(27, 269);
            this.cobx_Marka.Name = "cobx_Marka";
            this.cobx_Marka.Size = new System.Drawing.Size(249, 24);
            this.cobx_Marka.TabIndex = 3;
            this.cobx_Marka.SelectedIndexChanged += new System.EventHandler(this.cobx_Marka_SelectedIndexChanged);
            // 
            // lbl_Marka
            // 
            this.lbl_Marka.AutoSize = true;
            this.lbl_Marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marka.Location = new System.Drawing.Point(21, 206);
            this.lbl_Marka.Name = "lbl_Marka";
            this.lbl_Marka.Size = new System.Drawing.Size(255, 36);
            this.lbl_Marka.TabIndex = 2;
            this.lbl_Marka.Text = "Marka Automobila";
            this.lbl_Marka.Click += new System.EventHandler(this.label1_Click);
            // 
            // cobx_Model
            // 
            this.cobx_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobx_Model.FormattingEnabled = true;
            this.cobx_Model.Location = new System.Drawing.Point(27, 411);
            this.cobx_Model.Name = "cobx_Model";
            this.cobx_Model.Size = new System.Drawing.Size(249, 24);
            this.cobx_Model.TabIndex = 5;
            this.cobx_Model.SelectedIndexChanged += new System.EventHandler(this.cobx_Model_SelectedIndexChanged);
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model.Location = new System.Drawing.Point(21, 348);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(255, 36);
            this.lbl_Model.TabIndex = 4;
            this.lbl_Model.Text = "Model Automobila";
            this.lbl_Model.Click += new System.EventHandler(this.lbl_Model_Click);
            // 
            // cobx_Oprema
            // 
            this.cobx_Oprema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobx_Oprema.FormattingEnabled = true;
            this.cobx_Oprema.Location = new System.Drawing.Point(574, 411);
            this.cobx_Oprema.Name = "cobx_Oprema";
            this.cobx_Oprema.Size = new System.Drawing.Size(196, 24);
            this.cobx_Oprema.TabIndex = 11;
            this.cobx_Oprema.SelectedIndexChanged += new System.EventHandler(this.cobx_Oprema_SelectedIndexChanged);
            // 
            // lbl_Oprema
            // 
            this.lbl_Oprema.AutoSize = true;
            this.lbl_Oprema.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Oprema.Location = new System.Drawing.Point(568, 348);
            this.lbl_Oprema.Name = "lbl_Oprema";
            this.lbl_Oprema.Size = new System.Drawing.Size(202, 36);
            this.lbl_Oprema.TabIndex = 10;
            this.lbl_Oprema.Text = "Paket Opreme";
            this.lbl_Oprema.Click += new System.EventHandler(this.lbl_Oprema_Click);
            // 
            // cobx_Mjenjač
            // 
            this.cobx_Mjenjač.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobx_Mjenjač.FormattingEnabled = true;
            this.cobx_Mjenjač.Location = new System.Drawing.Point(564, 269);
            this.cobx_Mjenjač.Name = "cobx_Mjenjač";
            this.cobx_Mjenjač.Size = new System.Drawing.Size(206, 24);
            this.cobx_Mjenjač.TabIndex = 9;
            this.cobx_Mjenjač.SelectedIndexChanged += new System.EventHandler(this.cobx_Mjenjač_SelectedIndexChanged);
            // 
            // lbl_Mjenjač
            // 
            this.lbl_Mjenjač.AutoSize = true;
            this.lbl_Mjenjač.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mjenjač.Location = new System.Drawing.Point(558, 206);
            this.lbl_Mjenjač.Name = "lbl_Mjenjač";
            this.lbl_Mjenjač.Size = new System.Drawing.Size(212, 36);
            this.lbl_Mjenjač.TabIndex = 8;
            this.lbl_Mjenjač.Text = "Vrsta Mjenjača";
            this.lbl_Mjenjač.Click += new System.EventHandler(this.lbl_Mjenjač_Click);
            // 
            // cobx_Gorivo
            // 
            this.cobx_Gorivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobx_Gorivo.FormattingEnabled = true;
            this.cobx_Gorivo.Location = new System.Drawing.Point(595, 129);
            this.cobx_Gorivo.Name = "cobx_Gorivo";
            this.cobx_Gorivo.Size = new System.Drawing.Size(175, 24);
            this.cobx_Gorivo.TabIndex = 7;
            this.cobx_Gorivo.SelectedIndexChanged += new System.EventHandler(this.cobx_Gorivo_SelectedIndexChanged);
            // 
            // lbl_Gorivo
            // 
            this.lbl_Gorivo.AutoSize = true;
            this.lbl_Gorivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gorivo.Location = new System.Drawing.Point(589, 66);
            this.lbl_Gorivo.Name = "lbl_Gorivo";
            this.lbl_Gorivo.Size = new System.Drawing.Size(181, 36);
            this.lbl_Gorivo.TabIndex = 6;
            this.lbl_Gorivo.Text = "Vrsta Goriva";
            this.lbl_Gorivo.Click += new System.EventHandler(this.lbl_Gorivo_Click);
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.BackColor = System.Drawing.Color.Red;
            this.btn_Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nazad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Nazad.Location = new System.Drawing.Point(704, 12);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(84, 33);
            this.btn_Nazad.TabIndex = 12;
            this.btn_Nazad.Text = "Nazad";
            this.btn_Nazad.UseVisualStyleBackColor = false;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 68);
            this.button1.TabIndex = 13;
            this.button1.Text = "Traži!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_Konfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.cobx_Oprema);
            this.Controls.Add(this.lbl_Oprema);
            this.Controls.Add(this.cobx_Mjenjač);
            this.Controls.Add(this.lbl_Mjenjač);
            this.Controls.Add(this.cobx_Gorivo);
            this.Controls.Add(this.lbl_Gorivo);
            this.Controls.Add(this.cobx_Model);
            this.Controls.Add(this.lbl_Model);
            this.Controls.Add(this.cobx_Marka);
            this.Controls.Add(this.lbl_Marka);
            this.Controls.Add(this.cobx_Vrsta);
            this.Controls.Add(this.lbl_Vrsta);
            this.Name = "form_Konfigurator";
            this.Text = "Konfigurator";
            this.Load += new System.EventHandler(this.Konfigurator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Vrsta;
        private System.Windows.Forms.ComboBox cobx_Vrsta;
        private System.Windows.Forms.ComboBox cobx_Marka;
        private System.Windows.Forms.Label lbl_Marka;
        private System.Windows.Forms.ComboBox cobx_Model;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.ComboBox cobx_Oprema;
        private System.Windows.Forms.Label lbl_Oprema;
        private System.Windows.Forms.ComboBox cobx_Mjenjač;
        private System.Windows.Forms.Label lbl_Mjenjač;
        private System.Windows.Forms.ComboBox cobx_Gorivo;
        private System.Windows.Forms.Label lbl_Gorivo;
        private System.Windows.Forms.Button btn_Nazad;
        private System.Windows.Forms.Button button1;
    }
}