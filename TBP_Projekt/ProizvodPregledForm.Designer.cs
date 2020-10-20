namespace TBP_Projekt
{
    partial class ProizvodPregledForm
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
            this.dataGridViewProizvod = new System.Windows.Forms.DataGridView();
            this.dataGridViewRoba = new System.Windows.Forms.DataGridView();
            this.buttonNovi = new System.Windows.Forms.Button();
            this.buttonIzmjena = new System.Windows.Forms.Button();
            this.buttonBriši = new System.Windows.Forms.Button();
            this.robaidRobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.robaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodhasRobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProizvodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProizvod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodhasRobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProizvod
            // 
            this.dataGridViewProizvod.AllowUserToAddRows = false;
            this.dataGridViewProizvod.AllowUserToDeleteRows = false;
            this.dataGridViewProizvod.AutoGenerateColumns = false;
            this.dataGridViewProizvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProizvod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProizvodDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn});
            this.dataGridViewProizvod.DataSource = this.proizvodBindingSource;
            this.dataGridViewProizvod.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProizvod.Name = "dataGridViewProizvod";
            this.dataGridViewProizvod.ReadOnly = true;
            this.dataGridViewProizvod.RowTemplate.Height = 24;
            this.dataGridViewProizvod.Size = new System.Drawing.Size(401, 150);
            this.dataGridViewProizvod.TabIndex = 0;
            this.dataGridViewProizvod.SelectionChanged += new System.EventHandler(this.dataGridViewProizvod_SelectionChanged);
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
            this.dataGridViewRoba.DataSource = this.proizvodhasRobaBindingSource;
            this.dataGridViewRoba.Location = new System.Drawing.Point(419, 12);
            this.dataGridViewRoba.Name = "dataGridViewRoba";
            this.dataGridViewRoba.ReadOnly = true;
            this.dataGridViewRoba.RowTemplate.Height = 24;
            this.dataGridViewRoba.Size = new System.Drawing.Size(351, 150);
            this.dataGridViewRoba.TabIndex = 1;
            // 
            // buttonNovi
            // 
            this.buttonNovi.Location = new System.Drawing.Point(419, 168);
            this.buttonNovi.Name = "buttonNovi";
            this.buttonNovi.Size = new System.Drawing.Size(101, 45);
            this.buttonNovi.TabIndex = 33;
            this.buttonNovi.Text = "Novi";
            this.buttonNovi.UseVisualStyleBackColor = true;
            this.buttonNovi.Click += new System.EventHandler(this.buttonNovi_Click);
            // 
            // buttonIzmjena
            // 
            this.buttonIzmjena.Location = new System.Drawing.Point(526, 168);
            this.buttonIzmjena.Name = "buttonIzmjena";
            this.buttonIzmjena.Size = new System.Drawing.Size(119, 45);
            this.buttonIzmjena.TabIndex = 32;
            this.buttonIzmjena.Text = "Izmjeni";
            this.buttonIzmjena.UseVisualStyleBackColor = true;
            this.buttonIzmjena.Click += new System.EventHandler(this.buttonIzmjena_Click);
            // 
            // buttonBriši
            // 
            this.buttonBriši.Location = new System.Drawing.Point(651, 168);
            this.buttonBriši.Name = "buttonBriši";
            this.buttonBriši.Size = new System.Drawing.Size(119, 45);
            this.buttonBriši.TabIndex = 31;
            this.buttonBriši.Text = "Briši";
            this.buttonBriši.UseVisualStyleBackColor = true;
            this.buttonBriši.Click += new System.EventHandler(this.buttonBriši_Click);
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
            // robaBindingSource
            // 
            this.robaBindingSource.DataSource = typeof(TBP_Projekt.Roba);
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proizvodhasRobaBindingSource
            // 
            this.proizvodhasRobaBindingSource.DataSource = typeof(TBP_Projekt.Proizvod_has_Roba);
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
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proizvodBindingSource
            // 
            this.proizvodBindingSource.DataSource = typeof(TBP_Projekt.Proizvod);
            // 
            // ProizvodPregledForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 323);
            this.Controls.Add(this.buttonNovi);
            this.Controls.Add(this.buttonIzmjena);
            this.Controls.Add(this.buttonBriši);
            this.Controls.Add(this.dataGridViewRoba);
            this.Controls.Add(this.dataGridViewProizvod);
            this.Name = "ProizvodPregledForm";
            this.Text = "ProizvodPregledForm";
            this.Load += new System.EventHandler(this.ProizvodPregledForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProizvod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodhasRobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProizvodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proizvodBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewRoba;
        private System.Windows.Forms.DataGridViewComboBoxColumn robaidRobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource robaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proizvodhasRobaBindingSource;
        private System.Windows.Forms.Button buttonNovi;
        private System.Windows.Forms.Button buttonIzmjena;
        private System.Windows.Forms.Button buttonBriši;
    }
}