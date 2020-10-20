namespace TBP_Projekt
{
    partial class Prijava
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
            this.buttonPrijaviSe = new System.Windows.Forms.Button();
            this.LabelaLozinka = new System.Windows.Forms.Label();
            this.LabelKorime = new System.Windows.Forms.Label();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.textboxSifra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPrijaviSe
            // 
            this.buttonPrijaviSe.Location = new System.Drawing.Point(122, 205);
            this.buttonPrijaviSe.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrijaviSe.Name = "buttonPrijaviSe";
            this.buttonPrijaviSe.Size = new System.Drawing.Size(100, 28);
            this.buttonPrijaviSe.TabIndex = 14;
            this.buttonPrijaviSe.Text = "Prijavi se";
            this.buttonPrijaviSe.UseVisualStyleBackColor = true;
            this.buttonPrijaviSe.Click += new System.EventHandler(this.buttonPrijaviSe_Click);
            // 
            // LabelaLozinka
            // 
            this.LabelaLozinka.AutoSize = true;
            this.LabelaLozinka.Location = new System.Drawing.Point(93, 132);
            this.LabelaLozinka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelaLozinka.Name = "LabelaLozinka";
            this.LabelaLozinka.Size = new System.Drawing.Size(57, 17);
            this.LabelaLozinka.TabIndex = 13;
            this.LabelaLozinka.Text = "Lozinka";
            // 
            // LabelKorime
            // 
            this.LabelKorime.AutoSize = true;
            this.LabelKorime.Location = new System.Drawing.Point(93, 68);
            this.LabelKorime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelKorime.Name = "LabelKorime";
            this.LabelKorime.Size = new System.Drawing.Size(116, 17);
            this.LabelKorime.TabIndex = 12;
            this.LabelKorime.Text = "Šifra zaposlenika";
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(97, 152);
            this.textBoxLozinka.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.PasswordChar = '*';
            this.textBoxLozinka.Size = new System.Drawing.Size(165, 22);
            this.textBoxLozinka.TabIndex = 11;
            // 
            // textboxSifra
            // 
            this.textboxSifra.Location = new System.Drawing.Point(97, 88);
            this.textboxSifra.Margin = new System.Windows.Forms.Padding(4);
            this.textboxSifra.Name = "textboxSifra";
            this.textboxSifra.Size = new System.Drawing.Size(165, 22);
            this.textboxSifra.TabIndex = 10;
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 316);
            this.Controls.Add(this.buttonPrijaviSe);
            this.Controls.Add(this.LabelaLozinka);
            this.Controls.Add(this.LabelKorime);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textboxSifra);
            this.Name = "Prijava";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrijaviSe;
        private System.Windows.Forms.Label LabelaLozinka;
        private System.Windows.Forms.Label LabelKorime;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.TextBox textboxSifra;
    }
}

