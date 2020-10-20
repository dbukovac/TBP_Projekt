namespace TBP_Projekt
{
    partial class NarudzbePregledForm
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
            this.buttonNovi = new System.Windows.Forms.Button();
            this.buttonBriši = new System.Windows.Forms.Button();
            this.dataGridViewRoba = new System.Windows.Forms.DataGridView();
            this.robaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbahasRobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewNarudzbe = new System.Windows.Forms.DataGridView();
            this.idNarudzbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaprimljenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.robaidRobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbahasRobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNovi
            // 
            this.buttonNovi.Location = new System.Drawing.Point(380, 168);
            this.buttonNovi.Name = "buttonNovi";
            this.buttonNovi.Size = new System.Drawing.Size(101, 45);
            this.buttonNovi.TabIndex = 38;
            this.buttonNovi.Text = "Novi";
            this.buttonNovi.UseVisualStyleBackColor = true;
            this.buttonNovi.Click += new System.EventHandler(this.buttonNovi_Click);
            // 
            // buttonBriši
            // 
            this.buttonBriši.Location = new System.Drawing.Point(701, 168);
            this.buttonBriši.Name = "buttonBriši";
            this.buttonBriši.Size = new System.Drawing.Size(119, 45);
            this.buttonBriši.TabIndex = 36;
            this.buttonBriši.Text = "Briši";
            this.buttonBriši.UseVisualStyleBackColor = true;
            this.buttonBriši.Click += new System.EventHandler(this.buttonBriši_Click);
            // 
            // dataGridViewRoba
            // 
            this.dataGridViewRoba.AllowUserToAddRows = false;
            this.dataGridViewRoba.AllowUserToDeleteRows = false;
            this.dataGridViewRoba.AutoGenerateColumns = false;
            this.dataGridViewRoba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.robaidRobaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dataGridViewRoba.DataSource = this.narudzbahasRobaBindingSource;
            this.dataGridViewRoba.Location = new System.Drawing.Point(542, 12);
            this.dataGridViewRoba.Name = "dataGridViewRoba";
            this.dataGridViewRoba.ReadOnly = true;
            this.dataGridViewRoba.RowTemplate.Height = 24;
            this.dataGridViewRoba.Size = new System.Drawing.Size(278, 150);
            this.dataGridViewRoba.TabIndex = 35;
            // 
            // robaBindingSource
            // 
            this.robaBindingSource.DataSource = typeof(TBP_Projekt.Roba);
            // 
            // narudzbahasRobaBindingSource
            // 
            this.narudzbahasRobaBindingSource.DataSource = typeof(TBP_Projekt.Narudzba_has_Roba);
            // 
            // dataGridViewNarudzbe
            // 
            this.dataGridViewNarudzbe.AllowUserToAddRows = false;
            this.dataGridViewNarudzbe.AllowUserToDeleteRows = false;
            this.dataGridViewNarudzbe.AutoGenerateColumns = false;
            this.dataGridViewNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNarudzbaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.zaprimljenoDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridViewNarudzbe.DataSource = this.narudzbaBindingSource;
            this.dataGridViewNarudzbe.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewNarudzbe.Name = "dataGridViewNarudzbe";
            this.dataGridViewNarudzbe.ReadOnly = true;
            this.dataGridViewNarudzbe.RowTemplate.Height = 24;
            this.dataGridViewNarudzbe.Size = new System.Drawing.Size(524, 150);
            this.dataGridViewNarudzbe.TabIndex = 34;
            this.dataGridViewNarudzbe.SelectionChanged += new System.EventHandler(this.dataGridViewNarudzbe_SelectionChanged);
            // 
            // idNarudzbaDataGridViewTextBoxColumn
            // 
            this.idNarudzbaDataGridViewTextBoxColumn.DataPropertyName = "idNarudzba";
            this.idNarudzbaDataGridViewTextBoxColumn.HeaderText = "idNarudzba";
            this.idNarudzbaDataGridViewTextBoxColumn.Name = "idNarudzbaDataGridViewTextBoxColumn";
            this.idNarudzbaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zaprimljenoDataGridViewTextBoxColumn
            // 
            this.zaprimljenoDataGridViewTextBoxColumn.DataPropertyName = "zaprimljeno";
            this.zaprimljenoDataGridViewTextBoxColumn.HeaderText = "zaprimljeno";
            this.zaprimljenoDataGridViewTextBoxColumn.Name = "zaprimljenoDataGridViewTextBoxColumn";
            this.zaprimljenoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // narudzbaBindingSource
            // 
            this.narudzbaBindingSource.DataSource = typeof(TBP_Projekt.Narudzba);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 45);
            this.button1.TabIndex = 39;
            this.button1.Text = "Zaprimi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(487, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 45);
            this.button2.TabIndex = 40;
            this.button2.Text = "Izmjeni";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // robaidRobaDataGridViewTextBoxColumn
            // 
            this.robaidRobaDataGridViewTextBoxColumn.DataPropertyName = "Roba_idRoba";
            this.robaidRobaDataGridViewTextBoxColumn.DataSource = this.robaBindingSource;
            this.robaidRobaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.robaidRobaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.robaidRobaDataGridViewTextBoxColumn.HeaderText = "Roba";
            this.robaidRobaDataGridViewTextBoxColumn.Name = "robaidRobaDataGridViewTextBoxColumn";
            this.robaidRobaDataGridViewTextBoxColumn.ReadOnly = true;
            this.robaidRobaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.robaidRobaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.robaidRobaDataGridViewTextBoxColumn.ValueMember = "idRoba";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NarudzbePregledForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonNovi);
            this.Controls.Add(this.buttonBriši);
            this.Controls.Add(this.dataGridViewRoba);
            this.Controls.Add(this.dataGridViewNarudzbe);
            this.Name = "NarudzbePregledForm";
            this.Text = "NarudzbePregledForm";
            this.Load += new System.EventHandler(this.NarudzbePregledForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbahasRobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNovi;
        private System.Windows.Forms.Button buttonBriši;
        private System.Windows.Forms.DataGridView dataGridViewRoba;
        private System.Windows.Forms.DataGridView dataGridViewNarudzbe;
        private System.Windows.Forms.BindingSource narudzbaBindingSource;
        private System.Windows.Forms.BindingSource robaBindingSource;
        private System.Windows.Forms.BindingSource narudzbahasRobaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNarudzbaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaprimljenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewComboBoxColumn robaidRobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
    }
}