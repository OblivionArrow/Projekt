namespace WindowsFormsApp2
{
    partial class form_PočetniZaslon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_PočetniZaslon));
            this.btn_Dobrodošli = new System.Windows.Forms.Button();
            this.lbl_Naslov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Dobrodošli
            // 
            this.btn_Dobrodošli.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Dobrodošli.AutoSize = true;
            this.btn_Dobrodošli.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Dobrodošli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Dobrodošli.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dobrodošli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Dobrodošli.Location = new System.Drawing.Point(312, 399);
            this.btn_Dobrodošli.Name = "btn_Dobrodošli";
            this.btn_Dobrodošli.Size = new System.Drawing.Size(183, 48);
            this.btn_Dobrodošli.TabIndex = 0;
            this.btn_Dobrodošli.Text = "Dobrodošli";
            this.btn_Dobrodošli.UseVisualStyleBackColor = false;
            this.btn_Dobrodošli.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Naslov
            // 
            this.lbl_Naslov.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Naslov.AutoSize = true;
            this.lbl_Naslov.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Naslov.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Naslov.Location = new System.Drawing.Point(61, 26);
            this.lbl_Naslov.Name = "lbl_Naslov";
            this.lbl_Naslov.Size = new System.Drawing.Size(697, 116);
            this.lbl_Naslov.TabIndex = 1;
            this.lbl_Naslov.Text = "CarPerfect \r\nFinding the perfect car for You\r\n";
            this.lbl_Naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_PočetniZaslon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Naslov);
            this.Controls.Add(this.btn_Dobrodošli);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_PočetniZaslon";
            this.Text = "Početni Zaslon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Dobrodošli;
        private System.Windows.Forms.Label lbl_Naslov;
    }
}

