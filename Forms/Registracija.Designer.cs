namespace WindowsFormsApp2
{
    partial class form_Registracija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Registracija));
            this.btn_Registriraj2 = new System.Windows.Forms.Button();
            this.lbl_LozinkaReg = new System.Windows.Forms.Label();
            this.lbl_KorisničkoImeReg = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Registriraj2
            // 
            this.btn_Registriraj2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Registriraj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registriraj2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Registriraj2.Location = new System.Drawing.Point(54, 388);
            this.btn_Registriraj2.Name = "btn_Registriraj2";
            this.btn_Registriraj2.Size = new System.Drawing.Size(148, 50);
            this.btn_Registriraj2.TabIndex = 11;
            this.btn_Registriraj2.Text = "Registriraj se";
            this.btn_Registriraj2.UseVisualStyleBackColor = false;
            this.btn_Registriraj2.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_LozinkaReg
            // 
            this.lbl_LozinkaReg.AutoSize = true;
            this.lbl_LozinkaReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LozinkaReg.Location = new System.Drawing.Point(90, 302);
            this.lbl_LozinkaReg.Name = "lbl_LozinkaReg";
            this.lbl_LozinkaReg.Size = new System.Drawing.Size(80, 25);
            this.lbl_LozinkaReg.TabIndex = 10;
            this.lbl_LozinkaReg.Text = "Lozinka";
            this.lbl_LozinkaReg.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_KorisničkoImeReg
            // 
            this.lbl_KorisničkoImeReg.AutoSize = true;
            this.lbl_KorisničkoImeReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KorisničkoImeReg.Location = new System.Drawing.Point(72, 196);
            this.lbl_KorisničkoImeReg.Name = "lbl_KorisničkoImeReg";
            this.lbl_KorisničkoImeReg.Size = new System.Drawing.Size(139, 25);
            this.lbl_KorisničkoImeReg.TabIndex = 8;
            this.lbl_KorisničkoImeReg.Text = "Korisničko ime";
            this.lbl_KorisničkoImeReg.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(110, 89);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(60, 25);
            this.lbl_Email.TabIndex = 13;
            this.lbl_Email.Text = "Email";
            this.lbl_Email.Click += new System.EventHandler(this.lbl_Email_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 251);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 346);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 16;
            this.textBox3.PasswordChar = '*';
            this.textBox3.MaxLength = 15;
            // 
            // form_Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.btn_Registriraj2);
            this.Controls.Add(this.lbl_LozinkaReg);
            this.Controls.Add(this.lbl_KorisničkoImeReg);
            this.Name = "form_Registracija";
            this.Text = "Registracija";
            this.Load += new System.EventHandler(this.Registracija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Registriraj2;
        private System.Windows.Forms.Label lbl_LozinkaReg;
        private System.Windows.Forms.Label lbl_KorisničkoImeReg;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}