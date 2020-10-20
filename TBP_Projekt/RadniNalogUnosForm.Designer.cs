namespace TBP_Projekt
{
    partial class RadniNalogUnosForm
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewProizvod = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.idProizvod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProizvodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProizvod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Bilješke";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 253);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 58);
            this.textBox1.TabIndex = 45;
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(12, 196);
            this.numKolicina.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(120, 22);
            this.numKolicina.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Kolicina";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProizvod,
            this.naziv,
            this.kolicina});
            this.dataGridView1.Location = new System.Drawing.Point(331, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(339, 150);
            this.dataGridView1.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 45);
            this.button2.TabIndex = 37;
            this.button2.Text = "Dodaj u listu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewProizvod
            // 
            this.dataGridViewProizvod.AllowUserToAddRows = false;
            this.dataGridViewProizvod.AllowUserToDeleteRows = false;
            this.dataGridViewProizvod.AutoGenerateColumns = false;
            this.dataGridViewProizvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProizvod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProizvodDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn});
            this.dataGridViewProizvod.DataSource = this.proizvodBindingSource;
            this.dataGridViewProizvod.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProizvod.MultiSelect = false;
            this.dataGridViewProizvod.Name = "dataGridViewProizvod";
            this.dataGridViewProizvod.ReadOnly = true;
            this.dataGridViewProizvod.RowTemplate.Height = 24;
            this.dataGridViewProizvod.Size = new System.Drawing.Size(313, 150);
            this.dataGridViewProizvod.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 35;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idProizvod
            // 
            this.idProizvod.DataPropertyName = "idProizvod";
            this.idProizvod.HeaderText = "idProizvod";
            this.idProizvod.Name = "idProizvod";
            this.idProizvod.ReadOnly = true;
            // 
            // naziv
            // 
            this.naziv.DataPropertyName = "naziv";
            this.naziv.HeaderText = "naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            // 
            // kolicina
            // 
            this.kolicina.DataPropertyName = "kolicina";
            this.kolicina.HeaderText = "kolicina";
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
            // 
            // proizvodBindingSource
            // 
            this.proizvodBindingSource.DataSource = typeof(TBP_Projekt.Proizvod);
            // 
            // idProizvodDataGridViewTextBoxColumn
            // 
            this.idProizvodDataGridViewTextBoxColumn.DataPropertyName = "idProizvod";
            this.idProizvodDataGridViewTextBoxColumn.HeaderText = "idProizvod";
            this.idProizvodDataGridViewTextBoxColumn.Name = "idProizvodDataGridViewTextBoxColumn";
            this.idProizvodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RadniNalogUnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 323);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewProizvod);
            this.Controls.Add(this.button1);
            this.Name = "RadniNalogUnosForm";
            this.Text = "RadniNalogUnosForm";
            this.Load += new System.EventHandler(this.RadniNalogUnosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProizvod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewProizvod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProizvodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proizvodBindingSource;
    }
}