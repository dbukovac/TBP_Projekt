namespace TBP_Projekt
{
    partial class NarudzbaUnosForm
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
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewRoba = new System.Windows.Forms.DataGridView();
            this.idRobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dobavljacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.idRoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.numKolicina.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Kolicina";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRoba,
            this.naziv,
            this.kolicina});
            this.dataGridView1.Location = new System.Drawing.Point(331, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(449, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 45);
            this.button2.TabIndex = 25;
            this.button2.Text = "Dodaj u listu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewRoba
            // 
            this.dataGridViewRoba.AllowUserToAddRows = false;
            this.dataGridViewRoba.AllowUserToDeleteRows = false;
            this.dataGridViewRoba.AutoGenerateColumns = false;
            this.dataGridViewRoba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRobaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn});
            this.dataGridViewRoba.DataSource = this.robaBindingSource;
            this.dataGridViewRoba.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRoba.MultiSelect = false;
            this.dataGridViewRoba.Name = "dataGridViewRoba";
            this.dataGridViewRoba.ReadOnly = true;
            this.dataGridViewRoba.RowTemplate.Height = 24;
            this.dataGridViewRoba.Size = new System.Drawing.Size(313, 150);
            this.dataGridViewRoba.TabIndex = 24;
            // 
            // idRobaDataGridViewTextBoxColumn
            // 
            this.idRobaDataGridViewTextBoxColumn.DataPropertyName = "idRoba";
            this.idRobaDataGridViewTextBoxColumn.HeaderText = "idRoba";
            this.idRobaDataGridViewTextBoxColumn.Name = "idRobaDataGridViewTextBoxColumn";
            this.idRobaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // robaBindingSource
            // 
            this.robaBindingSource.DataSource = typeof(TBP_Projekt.Roba);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 23;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dobavljacBindingSource;
            this.comboBox1.DisplayMember = "naziv";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.ValueMember = "idDobavljac";
            // 
            // dobavljacBindingSource
            // 
            this.dobavljacBindingSource.DataSource = typeof(TBP_Projekt.Dobavljac);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Dobavljač";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 266);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 45);
            this.textBox1.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Bilješke";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(265, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 45);
            this.button3.TabIndex = 35;
            this.button3.Text = "Ekonomična količina";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idRoba
            // 
            this.idRoba.DataPropertyName = "idRoba";
            this.idRoba.HeaderText = "idRoba";
            this.idRoba.Name = "idRoba";
            this.idRoba.ReadOnly = true;
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
            // NarudzbaUnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 323);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewRoba);
            this.Controls.Add(this.button1);
            this.Name = "NarudzbaUnosForm";
            this.Text = "NarudzbaUnosForm";
            this.Load += new System.EventHandler(this.NarudzbaUnosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewRoba;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource robaBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource dobavljacBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
    }
}