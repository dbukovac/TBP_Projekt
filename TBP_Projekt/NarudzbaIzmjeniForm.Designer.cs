namespace TBP_Projekt
{
    partial class NarudzbaIzmjeniForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonNovi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Opis";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 122);
            this.textBox1.TabIndex = 2;
            // 
            // buttonNovi
            // 
            this.buttonNovi.Location = new System.Drawing.Point(109, 204);
            this.buttonNovi.Name = "buttonNovi";
            this.buttonNovi.Size = new System.Drawing.Size(101, 45);
            this.buttonNovi.TabIndex = 39;
            this.buttonNovi.Text = "Potvrdi";
            this.buttonNovi.UseVisualStyleBackColor = true;
            this.buttonNovi.Click += new System.EventHandler(this.buttonNovi_Click);
            // 
            // NarudzbaIzmjeniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 324);
            this.Controls.Add(this.buttonNovi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "NarudzbaIzmjeniForm";
            this.Text = "NarudzbaIzmjeniForm";
            this.Load += new System.EventHandler(this.NarudzbaIzmjeniForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonNovi;
    }
}