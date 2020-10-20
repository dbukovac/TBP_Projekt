namespace TBP_Projekt
{
    partial class RobaUnosForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numCS = new System.Windows.Forms.NumericUpDown();
            this.numCJD = new System.Windows.Forms.NumericUpDown();
            this.numMK = new System.Windows.Forms.NumericUpDown();
            this.numTD = new System.Windows.Forms.NumericUpDown();
            this.numP = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCJD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(99, 56);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(119, 22);
            this.textBoxNaziv.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cijena skladištenja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Minimalna količina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Trajanje dostave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cijena jedne dostave";
            // 
            // numCS
            // 
            this.numCS.DecimalPlaces = 2;
            this.numCS.Location = new System.Drawing.Point(99, 109);
            this.numCS.Margin = new System.Windows.Forms.Padding(4);
            this.numCS.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCS.Name = "numCS";
            this.numCS.Size = new System.Drawing.Size(122, 22);
            this.numCS.TabIndex = 18;
            // 
            // numCJD
            // 
            this.numCJD.DecimalPlaces = 2;
            this.numCJD.Location = new System.Drawing.Point(253, 62);
            this.numCJD.Margin = new System.Windows.Forms.Padding(4);
            this.numCJD.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCJD.Name = "numCJD";
            this.numCJD.Size = new System.Drawing.Size(137, 22);
            this.numCJD.TabIndex = 19;
            // 
            // numMK
            // 
            this.numMK.Location = new System.Drawing.Point(99, 165);
            this.numMK.Margin = new System.Windows.Forms.Padding(4);
            this.numMK.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numMK.Name = "numMK";
            this.numMK.Size = new System.Drawing.Size(122, 22);
            this.numMK.TabIndex = 20;
            // 
            // numTD
            // 
            this.numTD.Location = new System.Drawing.Point(253, 109);
            this.numTD.Margin = new System.Windows.Forms.Padding(4);
            this.numTD.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numTD.Name = "numTD";
            this.numTD.Size = new System.Drawing.Size(137, 22);
            this.numTD.TabIndex = 22;
            // 
            // numP
            // 
            this.numP.Location = new System.Drawing.Point(253, 165);
            this.numP.Margin = new System.Windows.Forms.Padding(4);
            this.numP.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numP.Name = "numP";
            this.numP.Size = new System.Drawing.Size(137, 22);
            this.numP.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Potražnja";
            // 
            // RobaUnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 323);
            this.Controls.Add(this.numP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numTD);
            this.Controls.Add(this.numMK);
            this.Controls.Add(this.numCJD);
            this.Controls.Add(this.numCS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "RobaUnosForm";
            this.Text = "RobaForm";
            this.Load += new System.EventHandler(this.RobaUnosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCJD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCS;
        private System.Windows.Forms.NumericUpDown numCJD;
        private System.Windows.Forms.NumericUpDown numMK;
        private System.Windows.Forms.NumericUpDown numTD;
        private System.Windows.Forms.NumericUpDown numP;
        private System.Windows.Forms.Label label5;
    }
}