namespace WindowsFormsApp2
{
    partial class form_Prijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Prijava));
            this.lbl_KorisničkoIme = new System.Windows.Forms.Label();
            this.lbl_Lozinka = new System.Windows.Forms.Label();
            this.btn_Prijavi = new System.Windows.Forms.Button();
            this.lbl_NemašRačun = new System.Windows.Forms.Label();
            this.btn_Registriraj2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_KorisničkoIme
            // 
            this.lbl_KorisničkoIme.AutoSize = true;
            this.lbl_KorisničkoIme.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KorisničkoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KorisničkoIme.Location = new System.Drawing.Point(604, 150);
            this.lbl_KorisničkoIme.Name = "lbl_KorisničkoIme";
            this.lbl_KorisničkoIme.Size = new System.Drawing.Size(139, 25);
            this.lbl_KorisničkoIme.TabIndex = 2;
            this.lbl_KorisničkoIme.Text = "Korisničko ime";
            // 
            // lbl_Lozinka
            // 
            this.lbl_Lozinka.AutoSize = true;
            this.lbl_Lozinka.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lozinka.Location = new System.Drawing.Point(617, 257);
            this.lbl_Lozinka.Name = "lbl_Lozinka";
            this.lbl_Lozinka.Size = new System.Drawing.Size(80, 25);
            this.lbl_Lozinka.TabIndex = 4;
            this.lbl_Lozinka.Text = "Lozinka";
            this.lbl_Lozinka.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Prijavi
            // 
            this.btn_Prijavi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Prijavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prijavi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Prijavi.Location = new System.Drawing.Point(606, 376);
            this.btn_Prijavi.Name = "btn_Prijavi";
            this.btn_Prijavi.Size = new System.Drawing.Size(114, 50);
            this.btn_Prijavi.TabIndex = 6;
            this.btn_Prijavi.Text = "Prijavi se";
            this.btn_Prijavi.UseVisualStyleBackColor = false;
            this.btn_Prijavi.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_NemašRačun
            // 
            this.lbl_NemašRačun.AutoSize = true;
            this.lbl_NemašRačun.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NemašRačun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NemašRačun.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_NemašRačun.Location = new System.Drawing.Point(388, 29);
            this.lbl_NemašRačun.Name = "lbl_NemašRačun";
            this.lbl_NemašRačun.Size = new System.Drawing.Size(209, 32);
            this.lbl_NemašRačun.TabIndex = 7;
            this.lbl_NemašRačun.Text = "Nemaš Račun?";
            this.lbl_NemašRačun.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_Registriraj2
            // 
            this.btn_Registriraj2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Registriraj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registriraj2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Registriraj2.Location = new System.Drawing.Point(622, 22);
            this.btn_Registriraj2.Name = "btn_Registriraj2";
            this.btn_Registriraj2.Size = new System.Drawing.Size(148, 50);
            this.btn_Registriraj2.TabIndex = 12;
            this.btn_Registriraj2.Text = "Registriraj se";
            this.btn_Registriraj2.UseVisualStyleBackColor = false;
            this.btn_Registriraj2.Click += new System.EventHandler(this.btn_Registriraj2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(609, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(609, 294);
            this.textBox2.MaxLength = 15;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 14;
            // 
            // form_Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Registriraj2);
            this.Controls.Add(this.lbl_NemašRačun);
            this.Controls.Add(this.btn_Prijavi);
            this.Controls.Add(this.lbl_Lozinka);
            this.Controls.Add(this.lbl_KorisničkoIme);
            this.Name = "form_Prijava";
            this.Text = "Prijava";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_Prijava_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_KorisničkoIme;
        private System.Windows.Forms.Label lbl_Lozinka;
        private System.Windows.Forms.Button btn_Prijavi;
        private System.Windows.Forms.Label lbl_NemašRačun;
        private System.Windows.Forms.Button btn_Registriraj2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}