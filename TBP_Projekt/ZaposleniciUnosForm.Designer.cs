namespace TBP_Projekt
{
    partial class ZaposleniciUnosForm
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
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxPozicija = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(106, 67);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(119, 22);
            this.textBoxIme.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime";
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(106, 130);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(119, 22);
            this.textBoxPrezime.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pozicija";
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(270, 130);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(148, 22);
            this.textBoxLozinka.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lozinka (samo brojevi)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxPozicija
            // 
            this.comboBoxPozicija.FormattingEnabled = true;
            this.comboBoxPozicija.Items.AddRange(new object[] {
            "admin",
            "radnik"});
            this.comboBoxPozicija.Location = new System.Drawing.Point(268, 67);
            this.comboBoxPozicija.Name = "comboBoxPozicija";
            this.comboBoxPozicija.Size = new System.Drawing.Size(150, 24);
            this.comboBoxPozicija.TabIndex = 12;
            // 
            // ZaposleniciUnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 323);
            this.Controls.Add(this.comboBoxPozicija);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label1);
            this.Name = "ZaposleniciUnosForm";
            this.Text = "ZaposleniciForm";
            this.Load += new System.EventHandler(this.ZaposleniciUnosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxPozicija;
    }
}